using System;
using System.Collections.Generic;
using System.Text;

namespace IP_Adressen_Scanner.DindoServices
{
    internal class ScanResults
    {
        public class ScanResult
        {
            public string Ip { get; set; }
            public int Port { get; set; }
            public bool IsOpen { get; set; }
        }
    }
}
