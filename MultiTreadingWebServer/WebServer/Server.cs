using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace WebServer
{
    public class Server
    {
        private TcpListener listener;

        /// <summary>
        /// Runs the server
        /// </summary>
        /// <param name="port">Port of the server </param>
        /// <param name="ipAddress"> IP address of the server</param>
        /// <param name="contentPath">Path of the displayed content </param>

        public void Run(int port, string ipAddress, string contentPath)
        {
            listener = new TcpListener(IPAddress.Parse(ipAddress), port);
            listener.Start();

            while (true)
            {
                TcpClient client = listener.AcceptTcpClient();
                Client tcpclient = new Client(client);
                Thread clientThread = new Thread(new ParameterizedThreadStart(tcpclient.HttpRequest));
                clientThread.Start(contentPath);
               
            }
        }
    }
}