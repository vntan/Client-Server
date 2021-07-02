using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Server.Class;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Server
{
    public partial class frmServer : Form
    {
        ListExchange exChanges;
        Dictionary<string, bool> clientLogin;
        Dictionary<string, string> users;
        bool isUpdate = true;

        public frmServer()
        {
            InitializeComponent();
            lblStatus.Text = "Last update: -";
            cbBank.DataSource = Constant.Instance.listBank.Keys.ToList();
            cbBank.SelectedIndex = 0;
            clientLogin = new Dictionary<string, bool>();
            users = new Dictionary<string, string>();
            readDataClient();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        #region Read Data User
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
                            users.Add(data[0], data[1]);
                        }
                    }
                }
            }
        }

        void writeDataClient(string username, string password)
        {
            File.AppendAllText(AppDomain.CurrentDomain.BaseDirectory + "dataUser.txt", username + " " + password + Environment.NewLine);
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

        void getData()
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

                    exChanges = JsonConvert.DeserializeObject<ListExchange>(temp);

                    lblStatus.Text = cbBank.SelectedValue.ToString() + " Last update: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm");
                }
            }
            catch (Exception e)
            {
            }
        }



        #endregion

        #region Socket

        bool checkLogin(string username, string password)
        {
            return users.ContainsKey(username) && users[username] == password;
        }

        void Process(Socket client)
        {
            clientLogin.Add(client.RemoteEndPoint.ToString(), false);
           
            ListViewItem item = new ListViewItem(client.RemoteEndPoint.ToString());
            ListViewItem.ListViewSubItem subitem = new ListViewItem.ListViewSubItem(item, "Unknown");
            item.SubItems.Add(subitem);
            lstClient.Items.Add(item);
            try
            {
                bool isContinue = true;
                var stream = new NetworkStream(client);
                var reader = new StreamReader(stream);
                var writer = new StreamWriter(stream);
                writer.AutoFlush = true;
                //Server sent data to client
                writer.WriteLine("Code");

                while (isContinue)
                {
                    // read data client send
                    string code = reader.ReadLine();
                    
                    if (!string.IsNullOrEmpty(code))
                    {
                        string[] words = code.Split(' ');
                        /* Client code format send
                         * Login Code: 10 Format: 10 <username> <password>
                         *      Reply: 200: Login Success
                         *             401: Login Fail
                         * Register Code: 20 Format: 20 <username> <password>
                         *      Reply: 200: Register Success
                         *             401: Register Fail
                         * Currency Code: 30 Format: 30 <exchange>
                         *      Reply: 200 <buy_cash> <buy_transfer> <sell>: Register Success
                         *             401: Not Login
                         *             404: Not found exchange
                         */

                        switch (words[0])
                        {
                            case "10":
                                //Login
                                if (words.Length == 3)
                                {
                                    if (checkLogin(words[1], words[2]))
                                    {
                                        lstClient.FindItemWithText(client.RemoteEndPoint.ToString()).SubItems[1].Text = words[1];
                                        clientLogin[client.RemoteEndPoint.ToString()] = true;
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
                                    writeDataClient(words[1], words[2]);
                                    users.Add(words[1], words[2]);
                                    writer.WriteLine("200");
                                }
                                else writer.WriteLine("401");
                                break;

                            case "30":
                                if (clientLogin[client.RemoteEndPoint.ToString()])
                                {
                                    if (words.Length == 2)
                                    {
                                        Exchange find = exChanges.findData(words[1]);
                                        if (find != null) {
                                            writer.WriteLine(String.Format("200 {0} {1} {2}", find.buy_cash, find.buy_transfer, find.sell));
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
                            isContinue = !(client.Poll(1, SelectMode.SelectRead) && client.Available == 0);
                        }
                        catch (SocketException) { isContinue = false; }
                    
                }
                stream.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex);
            }

            //MessageBox.Show("Exit "+ client.RemoteEndPoint);
            lstClient.Items.Remove(lstClient.FindItemWithText(client.RemoteEndPoint.ToString()));
            client.Close();
        }

        void connectServer()
        {
            //Create new server 
            Socket server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            server.ReceiveTimeout = 60000;
            server.SendTimeout = 60000;

            // Start listening.
            try
            {
                // add IP & Port to server
                int port = Int32.Parse(txtPort.Text);
                server.Bind(new IPEndPoint(IPAddress.Parse(txtIP.Text), port));
                server.Listen(20);
            }
            catch (Exception)
            {
                return;
            }


            while (true)
            {
                // Accept all client connected
                Socket client = server.Accept();
                Thread processClient = new Thread(() =>
                {
                    try
                    {
                        // Process data that users sended
                        Process(client);
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                });

                processClient.IsBackground = true;
                processClient.Start();

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
        }

        private void tmUpdate_Tick(object sender, EventArgs e)
        {
            if (System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable())
            {
                getData();
                isUpdate = false;
            }
            else isUpdate = true;
        }

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

        private void frmServer_Activated(object sender, EventArgs e)
        {
            if (System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable())
            {
                this.Text = "Server - Connected";
                if (btnStart.Text != "Started") btnStart.Enabled = true;

                txtIP.Text = GetLocalIPAddress();
                if (isUpdate)
                {
                    isUpdate = false;
                    getData();
                }
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
                btnStart.Enabled = false;
                txtPort.ReadOnly = true;

                getData();
                tmUpdate.Start();

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
                });

                thread.IsBackground = true;
                thread.Start();
                btnStart.Text = "Started";
            }
                
        }

        private void cbBank_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable())
            {
                getData();
                isUpdate = false;
            }
            else isUpdate = true;
        }
        #endregion


    }
}
