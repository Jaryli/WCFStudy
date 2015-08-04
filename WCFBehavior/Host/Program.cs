using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.ServiceModel.Dispatcher;

namespace Host
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost host = new ServiceHost(typeof(Service.Service1));
            host.Description.Endpoints[0].Behaviors.Add(new MyEndpointBehavior());
            host.Open();
            Console.WriteLine("服务已经开启！！！");

            for (int i = 0; i < host.ChannelDispatchers.Count; i++)
            {
                ChannelDispatcher channelDispatcher = (ChannelDispatcher) host.ChannelDispatchers[i];
                ServiceThrottle throttle = channelDispatcher.ServiceThrottle;
                Console.WriteLine("MaxConcurrentCalls:" + throttle.MaxConcurrentCalls);
                Console.WriteLine("MaxConcurrentInstances:" + throttle.MaxConcurrentInstances);
                Console.WriteLine("MaxConcurrentSessions:" + throttle.MaxConcurrentSessions);
                Console.ReadKey();
            }
            Console.Read();

        }
    }
}
