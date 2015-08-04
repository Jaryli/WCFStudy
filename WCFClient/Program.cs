using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;

namespace WCFClient
{
    class Program
    {
        static void Main(string[] args)
        {
            //basic 方式
            ChannelFactory<WcfServiceLib.IService1> factory = new ChannelFactory<WcfServiceLib.IService1>(new BasicHttpBinding(),
                                                                                    new EndpointAddress("http://localhost:8733/Design_Time_Addresses/WcfServiceLib/Service1/"));
            var client = factory.CreateChannel();
            var result = client.GetData(333);
            Console.WriteLine("Http::::"+result);


            //nettcp方式
            ChannelFactory<WcfSecondService.IService1> factorySecond = new ChannelFactory<WcfSecondService.IService1>(new NetTcpBinding(),
                                                                       new EndpointAddress("net.tcp://localhost:8735/Design_Time_Addresses/WcfSecondService/Service1/"));

           var clientTcp = factorySecond.CreateChannel();

           var resultStr = clientTcp.GetData(888);
           Console.WriteLine("net.TCP::::"+result);
           Console.ReadLine();

        }
    }
}
