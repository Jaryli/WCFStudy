using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            ChannelFactory<Service.IService1> factory = new ChannelFactory<Service.IService1>(new BasicHttpBinding(), new EndpointAddress("http://localhost:1720/Design_Time_Addresses/Service/Service1/"));
            var client = factory.CreateChannel();
            var result = client.GetData(333);
            var result1 = client.MyOperatorTest("输了很多很多很多很多很多很多很多…………");
            var result2 = client.MySecondOperatorTest("输了很多很多很多很多很多很多很多…………");
            Console.WriteLine("Http::::" + result);
            Console.WriteLine("有约束的::::" + result1);

            Console.WriteLine("无约束的::::" + result2);

            Console.ReadKey();
        }
    }
}
