using System.Runtime.CompilerServices;
using System.Collections.Generic;
using System.Threading;
using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Collections;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class Server
    {
        enum RequestType {None, Name, ChoiseSubject, Continue}

        private Dictionary<string, TcpClient> clients;

        public Server()
        {
            clients = new Dictionary<string, TcpClient>();
        }

        public void WaitNewConnections()
        {
            TcpListener server = null;
            try
            {
                Int32 port = 13000;
                IPAddress addr = IPAddress.Parse("127.0.0.1");
                server = new TcpListener(addr, port);
                server.Start();
                Console.WriteLine("Server online");
                while (true)
                {
                    TcpClient client = server.AcceptTcpClient();
                    clients.Add((clients.Count+1).ToString(), client);
                    Console.WriteLine("Connected new client");
                    (new Thread(new ParameterizedThreadStart(HandleConnection))).Start(client);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                server.Stop();
            }
        }

        public void HandleConnection(Object c)
        {
            TcpClient client = c as TcpClient;
            Console.WriteLine("New handler online");
        }

        public void RequestProcessing(string mess)
        {
            
        }

        public void SendMessage(TcpClient client, string mess)
        {

        }
    }
}
