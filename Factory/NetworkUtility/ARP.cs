using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory.NetworkUtility
{
    public class ARP : INetwork
    {
        public void SendRequest(string ip, int times)
        {
            Console.WriteLine($"ARP Request sent from {ip}, {times} times");
        }
    }
}
