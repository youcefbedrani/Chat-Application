using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets; 
namespace Chat_Application
{
    public partial class Form1 : Form
    {
        Socket sck;
        EndPoint ipLocal, ipRemote;
        public Form1()
        {
            InitializeComponent();
            //We create Initialize method at run time method
            //The Socket class provides a way to establish a connection
            //between a client and a server over a network, using various protocols and addressing schemes.
            //we put AddressFamily.InterNetwork ====> This parameter specifies the addressing scheme to be used,
            //in this case the Internet Protocol version 4 (IPv4) addressing scheme.
            //- we put SocketType.Dgram ====> A datagram socket is used for sending and receiving messages
            //that are not guaranteed to arrive at their destination.
            //--  we put ProtocolType.Udp ====> This parameter specifies the protocol to be used, in this case the User Datagram Protocol (UDP).
            //UDP is a connectionless protocol that is used for sending and receiving datagrams over a network.
            sck = new Socket(AddressFamily.InterNetwork , SocketType.Dgram , ProtocolType.Udp);
            //So, this statement sets the "ReuseAddress" option to true for the Socket object referenced by sck.
            //This allows multiple sockets to bind to the same IP address and port number,
            //which can be useful in certain scenarios,
            //such as in a server application that needs to handle multiple client connections.
            sck.SetSocketOption(SocketOptionLevel.Socket , SocketOptionName.ReuseAddress , true);
            //put local ip address in place
            ip11.Text = GetLocalIp();
            ip22.Text = GetLocalIp();
        }
        //we create method to get local ip and put it in ip place at form
        private string GetLocalIp()
        {
            //The GetHostName method of the Dns class retrieves the name of the local host on which the current application is running.
            //The GetHostEntry method then takes the host name as a parameter and returns an IPHostEntry object that contains information about the host.
            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach(IPAddress ip in host.AddressList){
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            return "127.0.0.1";
        }
        public void CallBackMessage(IAsyncResult aResult)
        {
            //The CallBackMessage method takes an IAsyncResult object as a parameter. This object is returned
            //by the asynchronous BeginReceiveFrom method of the Socket class when a message is received.
            try
            {
                int size = sck.EndReceiveFrom(aResult , ref ipRemote);
                //is called to get the size of the received message and the remote IP address and port.
                if (size > 0)
                {
                    //If the size of the received message is greater than 0,
                    //the method creates a byte array reciveData to hold the received message.
                    byte[] reciveData = new byte[1464];
                    //The AsyncState property of the IAsyncResult object is cast to a byte array and assigned to reciveData.
                    //This byte array contains the received message.
                    reciveData = (byte[])aResult.AsyncState;
                    //The received message is decoded using
                    //the ASCIIEncoding class to convert the bytes to a string.
                    ASCIIEncoding eEncoding = new ASCIIEncoding();
                    string receevidMessage = eEncoding.GetString(reciveData);
                    //The decoded message is added to a ListBox control with the name list_message.
                    list_message.Items.Add("Freind : " + receevidMessage);
                }
                //hold the received message with length 1500 byte
                byte[] buffer = new byte[1500];
                //that starts receiving messages asynchronously
                sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref ipRemote, new AsyncCallback(CallBackMessage) , buffer);
                // buffer : the buffer to hold the received message.
                // 0 : the offset in the buffer at which to begin storing the received message.
                // buffer.length : the maximum number of bytes to receive.
                // SocketFlags.None : the flags that specify how the message is received.
                // ipRemote : the remote IP address and port from which the message was sent.
                // CallBack function : the callback function that is called when a message is received.
                // buffer : an object that represents the state of the asynchronous operation.
                // When a message is received, the CallBackMessage method is called to handle the message.
                // The method is passed an IAsyncResult object that represents --- the state of the asynchronous operation --.
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void connect_Click(object sender, EventArgs e)
        {
            try
            {
                //The IPEndPoint class represents an IP address and a port number
                ipLocal = new IPEndPoint(IPAddress.Parse(ip11.Text) , Convert.ToInt32(port11.Text));
                sck.Bind(ipLocal);
                //This means that the socket will be bound to the specified IP address and port number,
                //and will only listen for incoming connections on that endpoint.
                ipRemote = new IPEndPoint(IPAddress.Parse(ip22.Text) , Convert.ToInt32(port22.Text));
                sck.Connect(ipRemote);

                byte[] buffer = new byte[1500];
                sck.BeginReceiveFrom(buffer , 0 , buffer.Length , SocketFlags.None , ref ipRemote , new AsyncCallback(CallBackMessage), buffer );
                //BeginReceiveFrom method is called on the client socket object sck to initiate an asynchronous receive operation.
                connect.Text = "Connected";
                connect.ForeColor = Color.WhiteSmoke;
                connect.BackColor = Color.Green;
                //when the connection is etablish we disable button connect 
                connect.Enabled= false;
                send.Enabled= true;
                textMessage.Focus();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void port1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void send_Click(object sender, EventArgs e)
        {
            try
            {
                System.Text.ASCIIEncoding enc = new System.Text.ASCIIEncoding();
                //convert a string that contains Unicode characters into a string that contains only ASCII characters
                byte[] msg = new byte[1500];
                //convert string message into assci code and store in byte array msg 
                msg = enc.GetBytes(textMessage.Text);
                // then send msg we put it in byte array
                sck.Send(msg);
                // last we put message in list message and clear message place 
                list_message.Items.Add("You :" + textMessage.Text);
                textMessage.Clear();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString()); 
            }
        }

        private void stop_Click(object sender, EventArgs e)
        {
            sck.Disconnect(false);
            sck.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}