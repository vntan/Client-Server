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
        public Client()
        {
            InitializeComponent();
        }

        #region No need to care about

        private void searchResult_Click(object sender, EventArgs e)
        {

        }
        private void Client_Load(object sender, EventArgs e)
        {

        }

        private void fourth_TextChanged(object sender, EventArgs e)
        {

        }

        private void third_TextChanged(object sender, EventArgs e)
        {

        }

        private void getport_TextChanged(object sender, EventArgs e)
        {

        }

        private void second_TextChanged(object sender, EventArgs e)
        {

        }

        private void first_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dot1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void getpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void listRegion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void signStatus_Click(object sender, EventArgs e)
        {

        }
        #endregion

        
        string ipaddress;
        IPEndPoint IP;
        Socket client;
        string status = "connect";
        NetworkStream stream;
        StreamReader reader;
        StreamWriter writer;

        private void pressToConnect_Click(object sender, EventArgs e)
        {
            ipaddress = first.Text;
            Connect();
        }

        private void signupbutton_Click(object sender, EventArgs e)
        {
            if (getusername.Text.Contains(" ") == true || getpassword.Text.Contains(" ") == true)
            {
                MessageBox.Show("Username and password cannot contain the space!!!");
                return;
            }
            Send("20 " + getusername.Text + " " + getpassword.Text);
            status = "Sign up ";
            Receive();
        }

        private void signinbutton_Click(object sender, EventArgs e)
        {
            if (getusername.Text.Contains(" ") == true || getpassword.Text.Contains(" ") == true)
            {
                MessageBox.Show("Username and password cannot contain the space!!!");
                return;
            }
            Send("10 " + getusername.Text + " " + getpassword.Text);
            status = "Sign in ";
            Receive();
        }

        // ket noi den server
        void Connect()
        {
            // IP: dia chi cua server
            try
            {
                IP = new IPEndPoint(IPAddress.Parse(ipaddress), Convert.ToInt32(getport.Text));
                client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            
                client.Connect(IP);
                statusConnect.Text = "Connected at " + first.Text + ':' + getport.Text;
                pressToConnect.Enabled = false;
                signinbutton.Enabled = true;
                signupbutton.Enabled = true;
                getusername.Enabled = true;
                getpassword.Enabled = true;
                status = "sign";

                //Hai doi tuong: reader: Doc tu client; writer: Viet cho Server
                stream = new NetworkStream(client);
                reader = new StreamReader(stream);
                writer = new StreamWriter(stream);
                writer.AutoFlush = true;

                string connectStatus = reader.ReadLine();
                if (connectStatus != "202") throw new Exception("Connect Failed!");
            }
            catch
            {
                statusConnect.Text = "Connection failed!";
                pressToConnect.Enabled = true;
                return;
            }
        }

        void getBankName_Money()
        {   try
            {
                Send("30");
                if (client.Poll(1, SelectMode.SelectRead) && client.Available == 0) throw new Exception("ERROR");
                string data = reader.ReadLine();

                string[] words = data.Split('_');

                if (words[0] == "200")
                {
                    nameofbank.Text = words[1];
                    for (int i = 2; i < words.Length; i++)
                    {
                        listRegion.Items.Add(words[i]);
                    }
                }
            }
            catch (Exception e)
            {
                Close();
                pressToConnect.Enabled = false;
                signinbutton.Enabled = false;
                signupbutton.Enabled = false;
                searchbutton.Enabled = false;
                MessageBox.Show("Error on getting bank name, please reopen the client!" + e.ToString());
            }
        }

        // dong ket noi
        void Close()
        {
            client.Close();
        }

        // nhan thong diep
        void Receive()
        {
            try
            {

                if (client.Poll(1, SelectMode.SelectRead) && client.Available == 0) throw new Exception("ERROR");
                string data = reader.ReadLine();

                if (data == "200")
                {   
                    if (status == "Sign in ")
                    {
                        signStatus.Text = "You are connected as " + getusername.Text;
                        signinbutton.Enabled = false;
                        signupbutton.Enabled = false;
                        searchbutton.Enabled = true;
                        getusername.Enabled = false;
                        getpassword.Enabled = false;
                        listRegion.Enabled = true;
                        getBankName_Money();
                    }
                    else
                        signStatus.Text = status + "completed";
                }
                else if (data == "401")
                    signStatus.Text = status + "failed";
                else if (data == "404")
                    searchResult.Text = "No found exchange";
                else
                    getExchange(data);

            } catch  (Exception e)
            {
                Close();
                pressToConnect.Enabled = false;
                signinbutton.Enabled = false;
                signupbutton.Enabled = false;
                searchbutton.Enabled = false;
                MessageBox.Show("Error on recieving message, please reopen the client!" + e.ToString());
            }
        }

        // gui thong diep
        void Send(string obj)
        {
           
            if (!(client.Poll(1, SelectMode.SelectRead) && client.Available == 0)) writer.WriteLine(obj);
        }

        void getExchange(string data)
        {
            string[] words = data.Split(' ');
            searchResult.Text = "Success";
            money_type.Text = listRegion.SelectedItem.ToString();
            buy_cash.Text = words[1];
            buy_transfer.Text = words[2];
            sell.Text = words[3];
        }

        // dong ket noi khi dong form
        private void Client_FormClosing(object sender, FormClosingEventArgs e)
        {   
            if (client != null)
                Close();
        }

        private void searchbutton_Click(object sender, EventArgs e)
        {
            if (listRegion.SelectedItem != null)
            {
                Send("40 " + listRegion.SelectedItem.ToString());
                Receive();
            }
            else
                searchResult.Text = "Please choose something!";
        }

       


    }
}
