using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Channels;
using System.Text;

namespace MyBindingDemo
{
    /// <summary>
    /// 自定义响应信道
    /// </summary>
    public class SimpleReplyChannel : SimpleChannelBase, IReplyChannel
    {
        public IReplyChannel InneReplyChannel
        {
            get { return (IReplyChannel)this.InnerChannel; }
        }

        public SimpleReplyChannel(ChannelManagerBase channelManager, IReplyChannel innerChannel)
            : base(channelManager, (ChannelBase)innerChannel)
        {
        }

        public IAsyncResult BeginReceiveRequest(TimeSpan timeout, AsyncCallback callback, object state)
        {
            Print("BeginReceiveRequest(）");
            return this.InneReplyChannel.BeginReceiveRequest(timeout, callback, state);
        }

        public IAsyncResult BeginReceiveRequest(AsyncCallback callback, object state)
        {
            throw new NotImplementedException();
        }

        public IAsyncResult BeginTryReceiveRequest(TimeSpan timeout, AsyncCallback callback, object state)
        {
            throw new NotImplementedException();
        }

        public IAsyncResult BeginWaitForRequest(TimeSpan timeout, AsyncCallback callback, object state)
        {
            throw new NotImplementedException();
        }

        public RequestContext EndReceiveRequest(IAsyncResult result)
        {
            throw new NotImplementedException();
        }

        public bool EndTryReceiveRequest(IAsyncResult result, out RequestContext context)
        {
            throw new NotImplementedException();
        }

        public bool EndWaitForRequest(IAsyncResult result)
        {
            throw new NotImplementedException();
        }

        public System.ServiceModel.EndpointAddress LocalAddress
        {
            get { throw new NotImplementedException(); }
        }

        public RequestContext ReceiveRequest(TimeSpan timeout)
        {
            throw new NotImplementedException();
        }

        public RequestContext ReceiveRequest()
        {
            throw new NotImplementedException();
        }

        public bool TryReceiveRequest(TimeSpan timeout, out RequestContext context)
        {
            throw new NotImplementedException();
        }

        public bool WaitForRequest(TimeSpan timeout)
        {
            throw new NotImplementedException();
        }
    }
}
