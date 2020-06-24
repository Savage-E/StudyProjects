using System;
using WebServer;

namespace MultithreadingWebServer
{
    internal class StartServer
    {
        private static void Main(string[] args)
        {
           Server server= new Server();
           server.Run(80,"127.0.0.1", @"C:\Users\Massi\www");
           
        }
    }
}