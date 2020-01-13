using System;
using System.Net;
using System.Net.Sockets;

namespace IPTel
{
    class Program
    {
        static void Main(string[] args)
        {
            UdpClient udpClient = new UdpClient(3231);
            udpClient.Connect(IPAddress.Parse("10.1.4.82"), 3231);
            udpClient.Close();
            UdpClient senderUdp = new UdpClient(3231);
            var buf = new byte[8192];
            var bytes = System.Text.Encoding.UTF8.GetString(buf);
            Console.Beep(buf.Length, 150000);
            senderUdp.Close();
        }
    }
}
