using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace IdentResponseChecker
{
    public class IdentChecker
    {
        public string ServerIP { get; private set; }
        public int Port { get; private set; }

        public IdentChecker(string serverIp, int port)
        {
            ServerIP = serverIp;
            Port = port;
        }

        public string TryGetIdentResponse()
        {
            try
            {
                using (TcpClient client = new TcpClient())
                {
                    client.Connect(ServerIP, Port);
                    string messageToSend = "0 , 0\r\n";
                    byte[] data = Encoding.ASCII.GetBytes(messageToSend);
                    NetworkStream stream = client.GetStream();
                    stream.Write(data, 0, data.Length);
                    Console.WriteLine("Send : " + messageToSend);
                    byte[] buffer = new byte[256];
                    int bytes = stream.Read(buffer, 0, buffer.Length);
                    string response = Encoding.ASCII.GetString(buffer, 0, bytes);

                    return response;
                }
            }
            catch (Exception e)
            {
                return e.ToString();
            }
        }
    }
}
    

