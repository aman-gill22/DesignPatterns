using DesignPatterns.Factory.NetworkUtility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory.NetworkFactory
{
    public class NetworkFactory
    {
        public INetwork GetNetworkInstance(string type)
        {
            if (type.ToLower().Equals("ping"))
            {
                return new Ping();
            }
            else if (type.ToLower().Equals("dns"))
            {
                return new DNS();
            }
            else if (type.ToLower().Equals("arp"))
            {
                return new ARP();
            }
            else
            {
                Console.WriteLine("Type not found");
                return null;
            }
        }
    }
}
