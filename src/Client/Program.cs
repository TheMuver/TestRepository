using System.Threading;
using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Client
{
    class Program
    {
        static NetworkStream stream;
        static TcpClient client;

        static void Main(string[] args)
        {
            try
            {
                Int32 port = 13000;
                IPAddress addr = IPAddress.Parse("");
                client = new TcpClient();
                client.Connect(addr.ToString(), port);               
            }
            catch(SocketException e)
            {
                Console.WriteLine("SocketException: {0}", e);
            }


        }


        public static void SendMessage(string data)
        {
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(data);
            stream = client.GetStream();
            stream.Write(msg, 0, msg.Length);
        }

        public static void HandleConnection(object c)
        {
            var client = c as TcpClient;
            Byte[] bytes = new Byte[256];
            string data = null;
            stream = client.GetStream();
            int i;

            while((i = stream.Read(bytes, 0, bytes.Length)) != 0)
            {
                data = System.Text.Encoding.ASCII.GetString(bytes, 0, i); 

                RequestProccesing(data);         
            }

            client.Close();
        }

        public static void RequestProccesing(string data)
        {
            stream = client.GetStream();            

            switch(data)
            {
                case "name?":
                    Console.WriteLine("Какое вы хотите себе имя?");
                    string name = Console.ReadLine();
                    SendMessage($"name:{name}");
                    break;
            }
        }
    }
}
