using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory.NetworkUtility
{
    public interface INetwork
    {
        void SendRequest(string ip, int times);
    }
}
