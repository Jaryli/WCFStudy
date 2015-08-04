using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Channels;
using System.Text;

namespace MyBindingDemo
{
    /// <summary>
    /// 自定义信道工厂
    /// </summary>
    /// <typeparam name="TChannel"></typeparam>
    class SimpleChannelFactory<TChannel> : ChannelFactoryBase<TChannel>
    {
        public IChannelFactory<TChannel> InnerChannelFactory;

        public SimpleChannelFactory(BindingContext context)
        {
            this.InnerChannelFactory = context.BuildInnerChannelFactory<TChannel>();
        }

        protected override TChannel OnCreateChannel(System.ServiceModel.EndpointAddress address, Uri via)
        {
       
            IRequestChannel innerChannel = this.InnerChannelFactory.CreateChannel(address, via) as IRequestChannel;       
            SimpleRequestChannel channel = new SimpleRequestChannel(this, innerChannel);
            return (TChannel)(object)channel;
        }
 
        protected override IAsyncResult OnBeginOpen(TimeSpan timeout, AsyncCallback callback, object state)
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
