using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;

namespace IP_Adressen_Scanner.DindoServices
{
    internal class Portscanner
    {
        public class PortScanner
        {
            public bool IsPortOpen(string ip, int port)
            {
                try
                {
                    using (TcpClient client = new TcpClient())
                    {
                        var result = client.BeginConnect(ip, port, null, null);
                        return result.AsyncWaitHandle.WaitOne(300);
                    }
                }
                catch
                {
                    return false;
                }
            }
        }
    }
}