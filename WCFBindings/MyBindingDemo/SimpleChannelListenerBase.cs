
using System;
using System.ServiceModel.Channels;

namespace MyBindingDemo
{
    /// <summary>
    /// 同SimpleChannelListener一样
    /// </summary>
    /// <typeparam name="TChannel"></typeparam>
    public abstract class SimpleChannelListenerBase<TChannel> :
        ChannelListenerBase<TChannel> where TChannel : class,IChannel
    {
        protected void Print(string methodName)
        {
            Console.WriteLine("{0}.{1}", this.GetType().Name, methodName);
        }

        public IChannelListener<TChannel> InnerChannelListener { get; private set; }

        protected SimpleChannelListenerBase(BindingContext context)
        {
            this.InnerChannelListener = context.BuildInnerChannelListener<TChannel>();
        }
        public override T GetProperty<T>()
        {
            return InnerChannelListener.GetProperty<T>();
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
