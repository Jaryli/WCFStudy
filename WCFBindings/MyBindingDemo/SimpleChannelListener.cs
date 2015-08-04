using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Channels;
using System.Text;

namespace MyBindingDemo
{
    /// <summary>
    /// 自定义信道监听器
    /// </summary>
    /// <typeparam name="TChannel"></typeparam>
    class SimpleChannelListener<TChannel> : ChannelListenerBase<TChannel> where TChannel : class,IChannel
    {
        public IChannelListener<TChannel> InnerChannelListener { get; private set; }

        public SimpleChannelListener(BindingContext context)
        {
            this.InnerChannelListener = context.BuildInnerChannelListener<TChannel>();
        }
        protected override TChannel OnAcceptChannel(TimeSpan timeout)
        {
            throw new NotImplementedException();
        }

        protected override IAsyncResult OnBeginAcceptChannel(TimeSpan timeout, AsyncCallback callback, object state)
        {
            throw new NotImplementedException();
        }

        protected override TChannel OnEndAcceptChannel(IAsyncResult result)
        {
            throw new NotImplementedException();
        }

        protected override IAsyncResult OnBeginWaitForChannel(TimeSpan timeout, AsyncCallback callback, object state)
        {
            throw new NotImplementedException();
        }

        protected override bool OnEndWaitForChannel(IAsyncResult result)
        {
            throw new NotImplementedException();
        }

        protected override bool OnWaitForChannel(TimeSpan timeout)
        {
            throw new NotImplementedException();
        }

        public override Uri Uri
        {
            get { throw new NotImplementedException(); }
        }

        protected override void OnAbort()
        {
            throw new NotImplementedException();
        }

        protected override IAsyncResult OnBeginClose(TimeSpan timeout, AsyncCallback callback, object state)
        {
            throw new NotImplementedException();
        }

        protected override IAsyncResult OnBeginOpen(TimeSpan timeout, AsyncCallback callback, object state)
        {
            throw new NotImplementedException();
        }

        protected override void OnClose(TimeSpan timeout)
        {
            throw new NotImplementedException();
        }

        protected override void OnEndClose(IAsyncResult result)
        {
            throw new NotImplementedException();
        }

        protected override void OnEndOpen(IAsyncResult result)
        {
            throw new NotImplementedException();
        }

        protected override void OnOpen(TimeSpan timeout)
        {
            throw new NotImplementedException();
        }
    }
}
