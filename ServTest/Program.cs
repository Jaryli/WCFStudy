using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
namespace ServTest
{
    class Program
    {
        static void Main(string[] args)
        {
            ChannelFactory<WCFInstanceMode.IMyService> factory = new ChannelFactory<WCFInstanceMode.IMyService>(new WSHttpBinding(), new EndpointAddress("http://localhost:8704/Design_Time_Addresses/WCFInstanceMode/MyService/"));
            var client = factory.CreateChannel();
            var data1 = client.DoWork();
            var data2 = client.DoWork();
            Console.WriteLine(data1);
            Console.WriteLine(data2);
            Console.ReadLine();
        }
    }
}
