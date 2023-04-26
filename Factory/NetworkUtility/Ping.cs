using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory.NetworkUtility
{
    public class Ping : INetwork
    {
        public void SendRequest(string ip, int times)
        {
            Console.WriteLine($"PING Request sent from {ip}, {times} times");
        }
    }
}
