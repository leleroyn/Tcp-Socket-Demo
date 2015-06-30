using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace SocketClient
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            TcpClient client = new TcpClient(tbServer.Text,int.Parse( tbPort.Text));
            NetworkStream stream = client.GetStream();
            byte[] msg = System.Text.UTF8Encoding.UTF8.GetBytes(tbMsg.Text);
            try
            {
                //发送报文
                stream.Write(msg, 0, msg.Length);
                //接收报文         
                byte[] repMsgData = new byte[1024];
                int repBytes = stream.Read(repMsgData, 0, repMsgData.Length);
                Console.WriteLine(repBytes);
                string repMsg = System.Text.UTF8Encoding.UTF8.GetString(repMsgData, 0, repBytes);
                tbRespose.Text = repMsg;
            }
            finally
            {
                stream.Close();
                client.Close();
            }
        }
    }
}
