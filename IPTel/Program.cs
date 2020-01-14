using System;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;
using Twilio.TwiML.Voice;

namespace IPTel
{
    class Program
    {
        static void Main(string[] args)
        {
            Call();
        }
        private static async Task Call()
        {
            
            UdpClient udpClient = new UdpClient(3231);
            udpClient.Connect(IPAddress.Parse("192.168.1.19"), 3231);
            udpClient.Close();
            UdpClient senderUdp = new UdpClient(3231);
            var buf = new byte[100];
            var bytes = System.Text.Encoding.UTF8.GetString(buf);;
            senderUdp.Close();
        }
    }
}
