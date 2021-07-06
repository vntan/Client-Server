using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class Client : Form
    {
        Socket client;
        NetworkStream stream;
        StreamReader reader;
        StreamWriter writer;
        bool isExit = false;

        public Client()
        {
            InitializeComponent();
        }


        #region Socket

        // xu li khi nhan nut tat
        void CloseConnect()
        {
            if (client != null)
            {
                client.Close(); 
                client = null;
            }
            if (reader != null)
                reader.Close();
            if (writer != null)
                writer.Close();
        }

        // ket noi den server
        void Connect()
        {
            // IP: dia chi cua server
            try
            {
                IPEndPoint IP = new IPEndPoint(IPAddress.Parse(txtIP.Text), Convert.ToInt32(txtPort.Text));
                client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            
                client.Connect(IP);
                statusConnect.Text = "Connected at " + txtIP.Text + ':' + txtPort.Text;
                
                ConnectUI();

                //Hai doi tuong: reader: Doc tu client; writer: Viet cho Server
                stream = new NetworkStream(client);
                reader = new StreamReader(stream);
                writer = new StreamWriter(stream);
                writer.AutoFlush = true;

                string connectStatus = reader.ReadLine();
                if (connectStatus != "202") throw new Exception("Connection failed!");
            }
            catch
            {
                MessageBox.Show("Connection failed. Please check it again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                statusConnect.Text = "Connection failed!";
                btnConnect.Enabled = true;
                return;
            }
        }

        // gui thong diep
        void Send(string obj)
        {
            if (!(client == null || (client.Poll(1, SelectMode.SelectRead) && client.Available == 0))) writer.WriteLine(obj);
            else CloseConnect();
        }

        // nhan thong diep
        void Receive(int request)
        {
            try
            {
                if (client == null || (client.Poll(1, SelectMode.SelectRead) && client.Available == 0)) throw new Exception("ERROR");
                string data = reader.ReadLine();

                switch (request)
                {
                    case 10:

                        switch (data)
                        {
                            case "200":
                                UpdateLoginUI();
                                Send("30");
                                Receive(30);
                                break;
                            case "401":
                                MessageBox.Show("Wrong username or password. Please check it again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                break;
                            case "502":
                            default: throw new Exception("Error");
                        }
                        break;
                    case 20:

                        switch (data)
                        {
                            case "200":
                                MessageBox.Show("Register success. Please login again!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break;
                            case "401":
                                MessageBox.Show("Register Error!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                break;
                            case "502":
                            default: throw new Exception("Error");
                        }

                        break;
                    case 30:
                        getBankName_Money(data);
                        break;
                    case 40:
                        getExchange(data);
                        break;
                    
                }   

            }
            catch
            {
                CloseConnect();
                DisconnectUI();
                MessageBox.Show("Error on recieving message, please reconnect to server!");
            }
        }
        #endregion

        #region UIProcess
        void DisconnectUI()
        {
            btnConnect.Enabled = true;
            btnDisconnect.Enabled = false;
            btnSignIn.Enabled = false;
            btnSignUp.Enabled = false;
            txtUserName.Enabled = false;
            txtPassword.Enabled = false;
            cbCurrency.Enabled = false;
            txtIP.Enabled = true;
            txtPort.Enabled = true;
            
            statusConnect.Text = "Not connected";
            //btnSearchResult.Text = "Search something";
            cbCurrency.Items.Clear();
            this.Text = "Client";
            pnLogin.Visible = true;
            pnResearch.Visible = false;
            this.Height = 330;

        }

        void ConnectUI()
        {
            btnConnect.Enabled = false;
            btnSignIn.Enabled = true;
            btnSignUp.Enabled = true;
            txtUserName.Enabled = true;
            txtPassword.Enabled = true;
            btnDisconnect.Enabled = true;
            txtIP.Enabled = false;
            txtPort.Enabled = false;
            pnLogin.Visible = true;
            pnResearch.Visible = false;
        }

        void UpdateLoginUI()
        {
            btnSignIn.Enabled = false;
            btnSignUp.Enabled = false;
            txtUserName.Enabled = false;
            txtPassword.Enabled = false;
            cbCurrency.Enabled = true;
            this.Text = "Client - " + txtUserName.Text;
            pnLogin.Visible = false;
            pnResearch.Visible = true;
            this.Height = 440;
        }

        #endregion

        #region Event

        // bam vao nut connect
        private void btnConnect_Click(object sender, EventArgs e)
        {
            Connect();
        }

        // bam vao nut sign up
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text.Contains(" ") == true || txtPassword.Text.Contains(" ") == true)
            {
                MessageBox.Show("Username and password cannot contain the spaces!!!");
                return;
            }
            Send("20_" + txtUserName.Text + "_" + txtPassword.Text); 
            
            Receive(20);
        }

        // bam vao nut sign in
        private void btnSignIn_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text.Contains("_") || txtPassword.Text.Contains("_"))
            {
                MessageBox.Show("Username and password cannot contain the spaces!!!");
                return;
            }
            Send("10_" + txtUserName.Text + "_" + txtPassword.Text);
            Receive(10);
        }

        // dong ket noi khi dong form
        private void Client_FormClosing(object sender, FormClosingEventArgs e)
        {
            isExit = true;
            CloseConnect();  
        }

        // bam vao nut disconnect
        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            CloseConnect();
            DisconnectUI();
        }

        // xu li khi thay doi loai tien
        void getExchange(string data)
        {
            string[] words = data.Split('_');

            switch (words[0])
            {
                case "200":
                    lbMoneyType.Text = cbCurrency.SelectedItem.ToString();
                    lbBuyCash.Text = words[1];
                    lbBuyTransfer.Text = words[2];
                    sell.Text = words[3];
                    break;
                case "401":
                    MessageBox.Show("Please login again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    break;
                case "404":
                    MessageBox.Show("Data not found !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case "502":
                default: throw new Exception("Error");
            }

        }

        // lay ten ngan hang, v.v
        void getBankName_Money(string data)
        {
            string[] words = data.Split('_');

            switch (words[0])
            {
                case "200":
                    lbBank.Text = words[1];
                    for (int i = 2; i < words.Length; i++) cbCurrency.Items.Add(words[i]);
                    break;
                case "401":
                    MessageBox.Show("Please login again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    break;
                case "404":
                    MessageBox.Show("Error data in server!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case "502":
                default: throw new Exception("Error");
            }

        }

        // thay doi loai tien
        private void cbCurrency_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCurrency.SelectedIndex >= 0)
            {
                Send("40_" + cbCurrency.SelectedItem.ToString());
                Receive(40);
            }
        }

        // xu li khi server ngat ket noi
        private void Client_Activated(object sender, EventArgs e)
        {
            if (!isExit)
                if (client == null || (client.Poll(1, SelectMode.SelectRead) && client.Available == 0))
                {
                    if (btnDisconnect.Enabled == true)
                    {
                        CloseConnect();
                        DisconnectUI();
                        MessageBox.Show("Server has closed!");
                    }
                }  
        }

        #endregion
    }
}
