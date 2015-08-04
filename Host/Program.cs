using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
namespace Host
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var host = new ServiceHost(typeof(ServiceMSMQ.MsmqService)))
            {
                try
                {
                    if (host.State != CommunicationState.Opened)
                    {
                        host.Open();
                        Console.WriteLine("服务开启！");
                        Console.Read();
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.Read();
                }
            }
        }
    }
}
