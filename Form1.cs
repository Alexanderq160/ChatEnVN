using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net;

using System.Net.Sockets;

namespace Chat_Client_APP
{
    public partial class Form1 : Form
    {
        Socket sck;
        EndPoint eplocal, epRemote;
        Validacion v = new Validacion();
        public Form1()
        {
            InitializeComponent();

            //sck = new Socket(AddressFamily.InterNetwork, SocketType.Dgram,protocolType.Udp);
            sck = new Socket(AddressFamily.InterNetwork,SocketType.Dgram, ProtocolType.Udp);
            sck.SetSocketOption(SocketOptionLevel.Socket,SocketOptionName.ReuseAddress, true);

            textLocalIp.Text = GetLocalIP();
            textFriendsIp.Text = GetLocalIP();
        }
        private string GetLocalIP()
        {
            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());

            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            return "127.0.0.1";
        }

        private void MessageCallBack(IAsyncResult aResult)
        {
            try
            {
                int size = sck.EndReceiveFrom(aResult,ref epRemote);
                if (size > 0)
                {
                    byte[] receivedData = new byte[1464];
                    receivedData = (byte[])aResult.AsyncState;
                    ASCIIEncoding eEncoding = new ASCIIEncoding();
                    String receivedMessage = eEncoding.GetString(receivedData);
                    listMessage.Items.Add("Amigo:"+receivedMessage);
                }
                byte[] buffer = new byte [1500];
                sck.BeginReceiveFrom (buffer,0,buffer.Length,SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack),buffer);

            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString());
            }
        }




        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                System.Text.ASCIIEncoding enc = new System.Text.ASCIIEncoding();
                byte[] msg = new byte [1500];
                msg = enc.GetBytes(textMessage.Text);

                sck.Send(msg);

                listMessage.Items.Add("TU]:" + textMessage.Text);
                textMessage.Clear();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                eplocal =  new IPEndPoint(IPAddress.Parse(textLocalIp.Text),Convert.ToInt32(textLocalPort.Text));
                sck.Bind(eplocal);
                epRemote = new IPEndPoint(IPAddress.Parse(textFriendsIp.Text), Convert.ToInt32(textFriendsPort.Text));
                sck.Connect(epRemote);
                byte[] buffer = new byte[1500];
                sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);

                button1.Text = "CONETADO";
                button1.Enabled = false;
                button2.Enabled = true;
                textMessage.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textLocalPort_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.soloNumeros(e);
        }

        private void textFriendsPort_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.soloNumeros(e);
        }

        private void textLocalIp_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.soloNumeros2(e);
        }

        private void textFriendsIp_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.soloNumeros2(e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }
    }
}
