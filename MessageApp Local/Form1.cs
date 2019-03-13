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

namespace MessageApp_Local
{
    public partial class Form1 : Form
    {
        Socket sck;
        EndPoint epLocal, epRemote;
        byte[] buffer;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Setup Up Socket
            sck = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            sck.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);

            //Get User IP
            IPTxtBoxUser1.Text = GetLocalIP();
            IPTxtBoxUser2.Text = GetLocalIP();
        }

        private string GetLocalIP()
        {
            IPHostEntry host = Dns.GetHostEntry(Dns.GetHostName());
            foreach(IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                    return (ip.ToString());
            }
            return ("127.0.0.1");
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            //Binding User Socket
            epLocal = new IPEndPoint(IPAddress.Parse(IPTxtBoxUser1.Text), Convert.ToInt32(PortUser1.Text));
            sck.Bind(epLocal);

            //Connect with the Remote IP
            epRemote = new IPEndPoint(IPAddress.Parse(IPTxtBoxUser2.Text), Convert.ToInt32(PortUser2.Text));
            sck.Connect(epRemote);

            //Listening to the Specific Port
            buffer = new byte[1500];
            sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote,
                new AsyncCallback(MessageCallBack), buffer);

            //Disable Connect Button
            ConnectButton.Enabled = false;
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            //Convert Message String to Byte Array
            ASCIIEncoding aEncoding = new ASCIIEncoding();
            byte[] sendingMessage = new byte[1500];
            sendingMessage = aEncoding.GetBytes(textMessage.Text);

            //Sending the Encoded Message
            sck.Send(sendingMessage);

            //Adding to the ListBox
            ListMessage.Items.Add("You: " + textMessage.Text);
            textMessage.Text = null;
        }

        private void MessageCallBack(IAsyncResult aResult)
        {
            try
            {
                byte[] receivedData = new byte[1500];
                receivedData = (byte[])aResult.AsyncState;
                //Converting byte[] to String
                ASCIIEncoding aEncoding = new ASCIIEncoding();
                string receivedMessage = aEncoding.GetString(receivedData);

                //Adding this Message into List Box
                ListMessage.Items.Add("User 2: " + receivedMessage);

                //Call back Again
                buffer = new byte[1500];
                sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote,
                    new AsyncCallback(MessageCallBack), buffer);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }            
        }
    }
}
