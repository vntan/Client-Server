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

        private void pressToConnect_Click(object sender, EventArgs e)
        {
            ipaddress = first.Text + '.' + second.Text + '.' + third.Text + '.' + fourth.Text;
            Connect();
        }

        private void signupbutton_Click(object sender, EventArgs e)
        {
            Send("signup");
            Send(getusername);
            Send(getpassword);
        }

        private void signinbutton_Click(object sender, EventArgs e)
        {
            Send("signin");
            Send(getusername);
            Send(getpassword);
        }

        // ket noi den server
        void Connect()
        {
            // IP: dia chi cua server
            IP = new IPEndPoint(IPAddress.Parse(ipaddress), Convert.ToInt32(getport.Text));
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                client.Connect(IP);
                statusConnect.Text = "Connected at " + first.Text + '.' + second.Text + '.' + third.Text + '.' + fourth.Text + ':' + getport.Text;
                pressToConnect.Enabled = false;
                signinbutton.Enabled = true;
                signupbutton.Enabled = true;
                getusername.Enabled = true;
                getpassword.Enabled = true;

            }
            catch
            {
                statusConnect.Text = "Connection failed!";
                pressToConnect.Enabled = true;
                return;
            }
            Thread listen = new Thread(Receive);
            listen.IsBackground = true;
            listen.Start();
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
                while (true)
                {
                    byte[] data = new byte[1024 * 10];
                    client.Receive(data);

                    string message = (string)Deserialize(data);
                    if (message == "signin" || message == "signup")
                    {
                        byte[] temp = new byte[1024 * 10];
                        client.Receive(temp);
                        string getmess = (string)Deserialize(temp);
                        if (getmess == "Signed in complete!")
                        {
                            signStatus.Text = "You are connected as " + getusername;
                            signinbutton.Enabled = false;
                            signupbutton.Enabled = false;
                            searchbutton.Enabled = true;
                            getusername.Enabled = false;
                            getpassword.Enabled = false;
                            listRegion.Enabled = true;
                        }
                        else
                            signStatus.Text = getmess;
                    }
                    else
                        searchResult.Text = message;
                }
            } catch
            {
                Close();
                pressToConnect.Enabled = false;
                signinbutton.Enabled = false;
                signupbutton.Enabled = false;
                searchbutton.Enabled = false;
                MessageBox.Show("Error on recieving message, please reopen the client!");
            }
        }

        // gui thong diep
        void Send(object obj)
        {
            client.Send(Serialize(obj));
        }

        // tach manh ra
        byte[] Serialize(object obj)
        {
            MemoryStream stream = new MemoryStream();
            BinaryFormatter formatter = new BinaryFormatter();

            formatter.Serialize(stream, obj);

            return stream.ToArray();
        }

        // gom manh lai
        object Deserialize(byte[] data)
        {
            MemoryStream stream = new MemoryStream(data);
            BinaryFormatter formatter = new BinaryFormatter();

            return formatter.Deserialize(stream);
        }

        // dong ket noi khi dong form
        private void Client_FormClosing(object sender, FormClosingEventArgs e)
        {
            Close();
        }



        private void searchbutton_Click(object sender, EventArgs e)
        {
            if (listRegion.SelectedItem.ToString() != string.Empty)
            {
                Send(listRegion.SelectedItem.ToString());
            }
            else
                searchResult.Text = "Please choose something!";
        }

        private void searchResult_Click(object sender, EventArgs e)
        {

        }


    }
}
