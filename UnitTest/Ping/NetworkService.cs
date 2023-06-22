using System;
using System.Collections.Generic;
using System.Text;

namespace NetworkUtility.Ping
{
    public class NetworkService
    {
        public NetworkService() { }
        public string SendPing()
        {
            return "Success: Ping Sent!";
        }
        public int PingTimeOut(int a, int b)
        {
            return a + b;

        }
    }
}
