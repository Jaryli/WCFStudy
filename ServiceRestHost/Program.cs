using System;
using System.ServiceModel.Web;
using ServiceEmployRest;

namespace ServiceRestHost
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var webserviceHost = new WebServiceHost(typeof(EmployService)))
            {
                webserviceHost.Opened += delegate
                {
                    Console.WriteLine("Rest Employee Service 开启成功!");
                };
                webserviceHost.Open();
                Console.WriteLine("按ENTER键关闭服务！");
                Console.ReadLine();
            }
        }
    }
}
