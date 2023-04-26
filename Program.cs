
using DesignPatterns.Factory.NetworkFactory;
using DesignPatterns.Singleton;

//Singleton object1 = Singleton.Instance();
//Singleton object2 = Singleton.Instance();

//if(object1 == object2)
//{
//    Console.WriteLine("These objects are the same");
//}

NetworkFactory factory = new NetworkFactory();

var ping = factory.GetNetworkInstance("ping");
var dns = factory.GetNetworkInstance("dns");
var arp = factory.GetNetworkInstance("arp");

ping.SendRequest("16.16.16.16", 7);
dns.SendRequest("17.17.17.17", 8);
arp.SendRequest("18.18.18.18", 9);


