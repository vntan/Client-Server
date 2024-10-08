﻿using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;

namespace Server
{
    public partial class frmServer : Form
    {
        bool isConnect = false;
        Socket server;
        ListExchange exChanges;
        Dictionary<string, bool> clientIsLogin;
        Dictionary<string, string> users;
        List<Socket> listClient;

        public frmServer()
        {
            InitializeComponent();
            initData();
        }

        #region Process
        //Khoi tao du lieu
        void initData()
        {
            cbBank.DataSource = Constant.Instance.listBank.Keys.ToList();
            cbBank.SelectedIndex = 0;
            clientIsLogin = new Dictionary<string, bool>();
            users = new Dictionary<string, string>();
            listClient = new List<Socket>();
            Control.CheckForIllegalCrossThreadCalls = false;
        }
        //Lay dia chi IP
        public string GetLocalIPAddress()
        {

            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            return "No network adapters with an IPv4 address in the system!";

        }

        #endregion

        #region Read Data User
        //Doc du lieu tu file
        void readDataClient()
        {
            if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + "dataUser.txt"))
            {
                string[] lines = System.IO.File.ReadAllLines(AppDomain.CurrentDomain.BaseDirectory + "dataUser.txt");
                foreach (string line in lines)
                {
                    if (!string.IsNullOrEmpty(line))
                    {
                        string[] data = line.Split(' ');
                        if (data.Length == 2 && !string.IsNullOrEmpty(data[0]) && !string.IsNullOrEmpty(data[1]))
                        {
                            if (users.ContainsKey(data[0])) users[data[0]] = data[1];
                            else users.Add(data[0], data[1]);
                        }
                    }
                }
            }
        }
        //Them username password vao trong file
        void writeDataClient(string username, string password)
        {
            if (users.Count > 0)
                File.AppendAllText(AppDomain.CurrentDomain.BaseDirectory + "dataUser.txt", Environment.NewLine + username + " " + password);
            else
            {
                File.AppendAllText(AppDomain.CurrentDomain.BaseDirectory + "dataUser.txt", username + " " + password);
            }

        }
        //Kiem tra ten dang nhap va mat khau
        bool checkLogin(string username, string password)
        {
            return users.ContainsKey(username) && users[username] == password;
        }
        #endregion

        #region Process Data From API

        string getToken()
        {
            string temp = string.Empty;
            try
            {
                HttpWebRequest requestToken = (HttpWebRequest)WebRequest.Create("https://vapi.vnappmob.com/api/request_api_key?scope=exchange_rate");

                using (HttpWebResponse response = (HttpWebResponse)requestToken.GetResponse())
                using (Stream stream = response.GetResponseStream())
                using (StreamReader reader = new StreamReader(stream))
                {
                    temp = reader.ReadToEnd();
                }

                JObject details = JObject.Parse(temp);
                return details["results"].ToString();

            }
            catch (Exception e)
            {
                //MessageBox.Show("Get Token Failed. Please check API again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //Application.Exit();
            }

            return temp;
        }

        bool getData()
        {
            try
            {
                string temp = String.Empty; string url = String.Empty;
                if (string.IsNullOrEmpty(cbBank.SelectedValue.ToString()))
                    url = Constant.Instance.listBank.ElementAt(0).Value;
                else url = Constant.Instance.listBank[cbBank.SelectedValue.ToString()];

                HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(url);

                webRequest.Method = "GET";
                webRequest.ContentType = "application/json";
                webRequest.Headers.Add("Authorization", "Bearer " + getToken());

                using (HttpWebResponse response = (HttpWebResponse)webRequest.GetResponse())
                {

                    using (Stream stream = response.GetResponseStream())
                    using (StreamReader reader = new StreamReader(stream))
                    {
                        temp = reader.ReadToEnd();
                    }
                    //MessageBox.Show(temp);

                    exChanges = JsonConvert.DeserializeObject<ListExchange>(temp, new JsonSerializerSettings { FloatParseHandling = FloatParseHandling.Double });

                    lblStatus.Text = cbBank.SelectedValue.ToString() + " Last update: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm");
                    return true;
                }
            }
            catch (Exception e)
            {
                return false;
            }
        }



        #endregion

        #region Socket
        //Xu ly du lieu gui va nhan cua client
        void process(int index)
        {
            clientIsLogin.Add(listClient[index].RemoteEndPoint.ToString(), false);

            ListViewItem item = new ListViewItem(listClient[index].RemoteEndPoint.ToString());
            ListViewItem.ListViewSubItem subitem = new ListViewItem.ListViewSubItem(item, "Unknown");
            item.SubItems.Add(subitem);
            lstClient.Items.Add(item);
            try
            {
                bool isContinue = true;
                var stream = new NetworkStream(listClient[index]);
                var reader = new StreamReader(stream);
                var writer = new StreamWriter(stream);
                writer.AutoFlush = true;
                //Server sent data to client
                writer.WriteLine("202");

                while (isContinue && isConnect)
                {
                    // read data client send
                    string code = reader.ReadLine();
                    //MessageBox.Show(code);
                    if (listClient.Count == 0 || !listClient[index].Connected) break;
                    if (!string.IsNullOrEmpty(code) && isConnect)
                    {
                        Socket client = listClient[index];
                        string[] words = code.Split('_');
                        /* Client code format send
                         * Login Code: 10 
                         *      Format: 10_<username>_<password>
                         *      Reply: 200: Login Success
                         *             401: Login Fail
                         * Register Code: 20 
                         *      Format: 20_<username>_<password>
                         *      Reply: 200: Register Success
                         *             401: Register Fail
                         * Get All Currency Code: 30 
                         *      Format: 30
                         *      Reply: 200_<Bank Name>_<Currency1>_<Currency2>_..._<CurrencyN>
                         *             401 Not Login
                         *             404 Not Found
                         * Currency Code: 40 
                         *      Format: 40_<Currency>
                         *      Reply: 200_<buy_cash>_<buy_transfer>_<sell>
                         *             401: Not Login
                         *             404: Not found Currency.
                         */

                        switch (words[0])
                        {
                            case "10":
                                //Login
                                if (words.Length == 3)
                                {
                                    readDataClient();
                                    if (checkLogin(words[1], words[2]))
                                    {
                                        lstClient.FindItemWithText(client.RemoteEndPoint.ToString()).SubItems[1].Text = words[1];
                                        clientIsLogin[client.RemoteEndPoint.ToString()] = true;
                                        writer.WriteLine("200");
                                    }
                                    else writer.WriteLine("401");
                                }
                                else writer.WriteLine("401");

                                break;
                            case "20":

                                //Register
                                if (words.Length == 3)
                                {
                                    readDataClient();
                                    if (!string.IsNullOrEmpty(words[1]) && !string.IsNullOrEmpty(words[2]) && words[1].All(c => Char.IsLetterOrDigit(c)) && words[2].All(c => Char.IsLetterOrDigit(c)) && !users.ContainsKey(words[1]))
                                    {

                                        writeDataClient(words[1], words[2]);
                                        users.Add(words[1], words[2]);
                                        writer.WriteLine("200");
                                    }
                                    else writer.WriteLine("401");
                                }
                                else writer.WriteLine("401");
                                break;

                            case "30":
                                if (clientIsLogin[client.RemoteEndPoint.ToString()])
                                {

                                    if (exChanges.Results.Count > 0 && cbBank.SelectedIndex >= 0)
                                    {
                                        string temp = String.Empty;
                                        foreach (Exchange e in exChanges.Results) temp += e.currency + "_";
                                        temp = temp.Remove(temp.Length - 1, 1);
                                        writer.WriteLine("200_" + cbBank.SelectedValue.ToString() + "_" + temp);
                                    }
                                    else writer.WriteLine("404");
                                }
                                else writer.WriteLine("401");
                                break;

                            case "40":
                                if (clientIsLogin[client.RemoteEndPoint.ToString()])
                                {
                                    if (words.Length == 2)
                                    {
                                        Exchange find = exChanges.findData(words[1]);
                                        if (find != null)
                                        {
                                            writer.WriteLine(String.Format("200_{0}_{1}_{2}", find.buy_cash, find.buy_transfer, find.sell));
                                        }
                                        else writer.WriteLine("404");
                                    }
                                    else writer.WriteLine("401");
                                }
                                else writer.WriteLine("401");
                                break;

                            default:
                                writer.WriteLine("404");
                                break;
                        }
                    }

                    try
                    {
                        isContinue = !(listClient[index].Poll(1, SelectMode.SelectRead) && listClient[index].Available == 0);
                    }
                    catch (SocketException) { isContinue = false; }

                }
                stream.Close();
            }
            catch (Exception ex)
            {
                // MessageBox.Show("Error CLient: " + ex);
                return;
            }

            //MessageBox.Show("Exit "+ client.RemoteEndPoint);
            if (listClient.Count != 0)
            {
                lstClient.Items.Remove(lstClient.FindItemWithText(listClient[index].RemoteEndPoint.ToString()));
                listClient[index].Close();
                listClient.RemoveAt(index);
            }
        }
        //Ket noi server
        void connectServer()
        {
            try
            {
                //Tao moi mot server
                server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                //server.ReceiveTimeout = 60000;
                //server.SendTimeout = 60000;

                // them IP & Port
                try
                {
                    int port = Int32.Parse(txtPort.Text);
                    server.Bind(new IPEndPoint(IPAddress.Parse(txtIP.Text), port));
                    server.Listen(20);
                    btnStart.Enabled = false;
                    btnStop.Enabled = true;
                    txtPort.ReadOnly = true;
                    cbBank.Enabled = false;
                    tmUpdate.Start();
                    btnStop.Visible = true;
                    btnStart.Visible = false;
                    isConnect = true;
                }
                catch (Exception)
                {
                    return;
                }

                //Neu ket noi thi xu ly ket noi cua client
                while (isConnect)
                {
                    // Accept all client connected
                    if (isConnect)
                    {
                        Socket client = server.Accept();

                        Thread processClient = new Thread(() =>
                        {
                            try
                            {
                                // Process data that users sended
                                listClient.Add(client);
                                process(listClient.Count - 1);
                            }

                            catch (Exception ex)
                            {
                                //MessageBox.Show("Server close." + ex.ToString());
                                return;
                            }
                            return;
                        });

                        processClient.IsBackground = true;
                        if (isConnect) processClient.Start();
                    }

                }
            }
            catch(SocketException e)
            {
                return;
            }



        }
        //Dong Server
        void closeServer()
        {
            isConnect = false;
            if (server != null)
            {
                server.Close();
                if (listClient != null)
                {
                    foreach (Socket s in listClient)
                    {
                        lstClient.Items.Remove(lstClient.FindItemWithText(s.RemoteEndPoint.ToString()));
                        s.Close();
                    }
                    listClient.Clear();
                }

            }
        }

        #endregion

        #region Events
        private void frmServer_Load(object sender, EventArgs e)
        {
            if (System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable()) txtIP.Text = GetLocalIPAddress();
        }

        private void frmServer_FormClosing(object sender, FormClosingEventArgs e)
        {
            tmUpdate.Stop();
            closeServer();
        }

        private void tmUpdate_Tick(object sender, EventArgs e)
        {
            if (System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable()) getData();
        }

        private void frmServer_Activated(object sender, EventArgs e)
        {
            if (System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable())
            {
                this.Text = "Server - Connected";
                if (btnStart.Text != "Started") btnStart.Enabled = true;
                txtIP.Text = GetLocalIPAddress();
            }
            else
            {
                this.Text = "Server - Disconnected";
                txtIP.Text = "";
                btnStart.Enabled = false;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable())
            {
                if (getData())
                {

                    Thread thread = new Thread(() =>
                    {
                        try
                        {
                            connectServer();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                            return;
                        }

                        return;
                    });

                    thread.IsBackground = true;
                    thread.Start();
                }
                else MessageBox.Show("Unable to get data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else MessageBox.Show("Network is not available.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            closeServer();
            
            //Update UI
            btnStart.Enabled = true;
            btnStop.Enabled = false;
            txtPort.ReadOnly = false;
            cbBank.Enabled = true;
            tmUpdate.Stop();
            btnStop.Visible = false;
            btnStart.Visible = true;
        }

        #endregion
    }
}
