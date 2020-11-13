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

        static void Main(string[] args)
        {
            try
            {
                Int32 port = 13000;
                IPAddress addr = IPAddress.Parse("");
                TcpClient client = new TcpClient();
                client.Connect(addr.ToString(), port);
                

                
            }
            catch(SocketException e)
            {
                
            }


        }


        public static void SendMessage(TcpClient client, string data)
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
            NetworkStream stream = client.GetStream();
            int i;

            while((i = stream.Read(bytes, 0, bytes.Length)) != 0)
            {
                data = System.Text.Encoding.ASCII.GetString(bytes, 0, i);
                Console.WriteLine(data);

                SendMessage(client, data);
            }

            client.Close();
        }
    }
}
