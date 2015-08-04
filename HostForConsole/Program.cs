using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using WcfServiceLib;

/**
 * 寄宿WcfServiceLib
 * 
 * **/
namespace HostForConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ServiceHost serviceHost = new ServiceHost(typeof(Service1));
                if (serviceHost.State != CommunicationState.Opened)
                {
                    serviceHost.Open();
                }
                Console.WriteLine("First服务正在运行......");
                
                var host2 = new ServiceHost(typeof(WcfSecondService.Service1));
                if (host2.State != CommunicationState.Opened)
                {
                    host2.Open();
                }
                Console.WriteLine("Second服务正在运行......");
                Console.WriteLine("输入回车键 <ENTER> 退出WCF服务");
                Console.ReadLine();
                serviceHost.Close();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex);
                Console.ReadLine();
            }


        }
    }
}
