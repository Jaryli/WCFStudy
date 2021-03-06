﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Channels;
using System.Text;

namespace MyBindingDemo
{
    /// <summary>
    /// 自定义双工会话信道
    /// </summary>
    class SimpleDuplexSessionChannel : SimpleChannelBase, IDuplexSessionChannel
    {
        public IDuplexSessionChannel InnerDuplexSessionChannel
        {
            get { return (IDuplexSessionChannel)this.InnerChannel; }
        }

        public SimpleDuplexSessionChannel(ChannelManagerBase channelManager, IDuplexSessionChannel innerChannel)
            : base(channelManager, (ChannelBase)innerChannel)
        {
            this.Print("SimpleDuplexSessionChannel()");
        }

        public IAsyncResult BeginReceive(TimeSpan timeout, AsyncCallback callback, object state)
        {
            throw new NotImplementedException();
        }

        public IAsyncResult BeginReceive(AsyncCallback callback, object state)
        {
            throw new NotImplementedException();
        }

        public IAsyncResult BeginTryReceive(TimeSpan timeout, AsyncCallback callback, object state)
        {
            throw new NotImplementedException();
        }

        public IAsyncResult BeginWaitForMessage(TimeSpan timeout, AsyncCallback callback, object state)
        {
            throw new NotImplementedException();
        }

        public Message EndReceive(IAsyncResult result)
        {
            throw new NotImplementedException();
        }

        public bool EndTryReceive(IAsyncResult result, out Message message)
        {
            throw new NotImplementedException();
        }

        public bool EndWaitForMessage(IAsyncResult result)
        {
            throw new NotImplementedException();
        }

        public System.ServiceModel.EndpointAddress LocalAddress
        {
            get { throw new NotImplementedException(); }
        }

        public Message Receive(TimeSpan timeout)
        {
            throw new NotImplementedException();
        }

        public Message Receive()
        {
            throw new NotImplementedException();
        }

        public bool TryReceive(TimeSpan timeout, out Message message)
        {
            throw new NotImplementedException();
        }

        public bool WaitForMessage(TimeSpan timeout)
        {
            throw new NotImplementedException();
        }

        public IAsyncResult BeginSend(Message message, TimeSpan timeout, AsyncCallback callback, object state)
        {
            throw new NotImplementedException();
        }

        public IAsyncResult BeginSend(Message message, AsyncCallback callback, object state)
        {
            throw new NotImplementedException();
        }

        public void EndSend(IAsyncResult result)
        {
            throw new NotImplementedException();
        }

        public System.ServiceModel.EndpointAddress RemoteAddress
        {
            get { throw new NotImplementedException(); }
        }

        public void Send(Message message, TimeSpan timeout)
        {
            throw new NotImplementedException();
        }

        public void Send(Message message)
        {
            throw new NotImplementedException();
        }

        public Uri Via
        {
            get { throw new NotImplementedException(); }
        }

        public IDuplexSession Session
        {
            get { throw new NotImplementedException(); }
        }
    }
}
