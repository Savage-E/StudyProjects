using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;

namespace WebServer
{
    public class Client
    {
        private TcpClient client;

        public Client(TcpClient tcpclient)
        {
            client = tcpclient;
        }

        public void HttpRequest(object path)
        {

            string pathcontent = (string)path;
            // Buffer for keeping received client data.
            byte[] buffer = new byte[1024];

            Console.WriteLine("нить" +Thread.CurrentThread.ManagedThreadId);

            string request = "";

            // Count of byte recieved from client.
            int count;
            // Read all data from client stream.
            while ((count = client.GetStream().Read(buffer, 0, buffer.Length)) > 0)
            {
                request += Encoding.ASCII.GetString(buffer, 0, count);

                if (request.IndexOf("\r\n\r\n") >= 0)
                {
                    break;
                }
            }

            Match reqMatch = Regex.Match(request, @"^\w+\s+([^\s\?]+)[^\s]*\s+HTTP/.*|");
           


            if (reqMatch.Value == "")
            {
                //Bad request.
                SendErrorResponse(400);
                return;
            }
            //Get file name.
            string requestUri = reqMatch.Groups[1].Value;
            //Protection from URL like http://127.0.0.1/../../show.txt.
            if (requestUri.IndexOf("..") >= 0)
            {
                SendErrorResponse(400);
                return;
            }

            requestUri = Uri.UnescapeDataString(requestUri);

            //If request is empty, open default page.
            if (requestUri == "")
                requestUri += "/index.html";
            else if (requestUri.EndsWith("/"))
                requestUri += "index.html";

            string filePath = pathcontent.Replace('\\', '/') + requestUri;

            if (!File.Exists(filePath))
            {
                SendErrorResponse(404);
                return;
            }
            string contentType = "";
            int dot = requestUri.LastIndexOf(".");
            string ext = requestUri.Substring(dot);
            if (extensions.ContainsKey(ext))
            {
                contentType = ext;
            }
            //RespondRequest.
           HttpRespond(contentType, filePath, count, buffer);

            client.Close();

        }

        protected void HttpRespond(string contentType, string path, int count, byte[] buffer)
        {




            FileStream FS;
            try
            {
                FS = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read);
            }
            catch (Exception)
            {
                // If error has occured , send an error code.
                SendErrorResponse(500);
                return;
            }

            string headers = "HTTP/1.1 200 OK\nContent-Type: " + contentType + "\nContent-Length: " + FS.Length + "\n\n";
            byte[] headersBuffer = Encoding.ASCII.GetBytes(headers);
            client.GetStream().Write(headersBuffer, 0, headersBuffer.Length);

            //Read data from file and send it to the client.
           
            while (FS.Position < FS.Length)
            {
                count = FS.Read(buffer, 0, buffer.Length);
                
                client.GetStream().Write(buffer, 0, count);
            }
      
            FS.Close();
            
        }

        private void SendErrorResponse(int code)
        {
            string codeStr = code.ToString() + " " + ((HttpStatusCode)code).ToString();

            string html = "<html><body><p align=\"center\"style=\"font-size:100px\">" + codeStr + "<big><big></p>" + "<p align=\"center\"style= \"font-size:20px\">" + "Sorry, something went wrong" + "<big><big></p></body></html>";

            string str = "HTTP/1.1 " + codeStr + "\nContent-type: text/html\nContent-Length:" + html.Length.ToString() + "\n\n" + html;

            byte[] buffer = Encoding.ASCII.GetBytes(str);

            client.GetStream().Write(buffer, 0, buffer.Length);

            client.Close();
        }

        //Mime types.
        private Dictionary<string, string> extensions = new Dictionary<string, string>()
        {
          //{ "extension", "content type" }
          { "htm", "text/html" },
          { "html", "text/html" },
          { "xml", "text/xml" },
          { "txt", "text/plain" },
          { "css", "text/css" },
          { "png", "image/png" },
          { "gif", "image/gif" },
          { "jpg", "image/jpg" },
          { "jpeg", "image/jpeg" },
          { "zip", "application/zip"},
          { "","application/unknown"}
        };
    }
}