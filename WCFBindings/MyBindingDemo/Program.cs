using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.ServiceModel.Channels;
namespace MyBindingDemo
{
    /// <summary>
    /// 【信道栈】：协议信道，编号信道，传输信道
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var binding1 = new WSHttpBinding().CreateBindingElements();
            var binding2 = new NetTcpBinding().CreateBindingElements();
            var binding3 = new BasicHttpBinding().CreateBindingElements();

            Console.WriteLine(binding1.ToString());
            Console.ReadLine();

            var custombind = new CustomBinding();
            custombind.Elements.Add(new BinaryMessageEncodingBindingElement());
            custombind.Elements.Add(new HttpTransportBindingElement());
        }
    }
}
