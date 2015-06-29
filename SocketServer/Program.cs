using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SocketServer.Core;

namespace SocketServer
{
    class Program
    {
        static AsyncTcpServer server;
        static log4net.ILog Logger ;

        static void Main(string[] args)
        {
            log4net.Config.XmlConfigurator.Configure();
            Logger = log4net.LogManager.GetLogger(typeof(AsyncTcpServer));

            server = new AsyncTcpServer(9999);
            server.Encoding = Encoding.UTF8;
            server.ClientConnected +=
              new EventHandler<TcpClientConnectedEventArgs>(server_ClientConnected);
            server.ClientDisconnected +=
              new EventHandler<TcpClientDisconnectedEventArgs>(server_ClientDisconnected);
            server.PlaintextReceived +=
              new EventHandler<TcpDatagramReceivedEventArgs<string>>(server_PlaintextReceived);
            server.Start();

            Console.WriteLine("TCP server has been started.");
            Console.WriteLine("Type something to send to client...");
            while (true)
            {
                string text = Console.ReadLine();
                server.SendAll(text);
            }
        }

        static void server_ClientConnected(object sender, TcpClientConnectedEventArgs e)
        {
            Logger.Debug(string.Format(CultureInfo.InvariantCulture,
              "TCP client {0} has connected.",
              e.TcpClient.Client.RemoteEndPoint.ToString()));
        }

        static void server_ClientDisconnected(object sender, TcpClientDisconnectedEventArgs e)
        {
            Logger.Debug(string.Format(CultureInfo.InvariantCulture,
              "TCP client {0} has disconnected.",
              e.TcpClient.Client.RemoteEndPoint.ToString()));
        }

        static void server_PlaintextReceived(object sender, TcpDatagramReceivedEventArgs<string> e)
        {
            if (e.Datagram != "Received")
            {
                Console.Write(string.Format("Client : {0} --> ",
                  e.TcpClient.Client.RemoteEndPoint.ToString()));
                Console.WriteLine(string.Format("{0}", e.Datagram));
                server.Send(e.TcpClient, "Server has received you text : " + e.Datagram);
            }
        }

    }
}
