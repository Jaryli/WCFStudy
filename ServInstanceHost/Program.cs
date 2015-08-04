using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using WCFInstanceMode;
namespace ServInstanceHost
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var host = new ServiceHost(typeof(MyService)))
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
