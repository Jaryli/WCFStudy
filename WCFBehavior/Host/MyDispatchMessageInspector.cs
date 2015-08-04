using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.ServiceModel.Dispatcher;
namespace Host
{
    public class MyDispatchMessageInspector : IDispatchMessageInspector
    {

        public object AfterReceiveRequest(ref System.ServiceModel.Channels.Message request, IClientChannel channel, InstanceContext instanceContext)
        {
            Console.WriteLine("我是请求：：：："+request.ToString());
            return request;
        }

        public void BeforeSendReply(ref System.ServiceModel.Channels.Message reply, object correlationState)
        {
            Console.WriteLine("我是响应：：：："+reply.ToString ());
        }
    }
}
