using System;
using System.Runtime.InteropServices;
using System.ServiceModel.Channels;

namespace MyBindingDemo
{
    /// <summary>
    /// 自定义信道基类
    /// </summary>
    public abstract class SimpleChannelBase : ChannelBase
    {
        #region 自定义属性及方法
        public ChannelBase InnerChannel { get; private set; }

        public override T GetProperty<T>()
        {
            return InnerChannel.GetProperty<T>();
        }

        protected void Print(string methodName)
        {
            Console.WriteLine("{0}.{1}", this.GetType().Name, methodName);
        }

        protected SimpleChannelBase(ChannelManagerBase channelManager, ChannelBase inChannelBase)
            : base(channelManager)
        {
            this.InnerChannel = inChannelBase;
        }
        #endregion

        #region 实现父类方法
        protected override void OnAbort()
        {
            Print("OnAbort");
            this.InnerChannel.Abort();
        }

        protected override IAsyncResult OnBeginClose(TimeSpan timeout, AsyncCallback callback, object state)
        {
            Print("OnBeginClose");
            return this.InnerChannel.BeginClose(timeout, callback, state);
        }

        protected override IAsyncResult OnBeginOpen(TimeSpan timeout, AsyncCallback callback, object state)
        {
            Print("OnBeginOpen");
            return this.InnerChannel.BeginOpen(timeout, callback, state);
        }

        protected override void OnClose(TimeSpan timeout)
        {
            Print("OnClose");
            this.InnerChannel.Close(timeout);
        }

        protected override void OnEndClose(IAsyncResult result)
        {
            Print("OnEndClose");
            this.InnerChannel.EndClose(result);
        }

        protected override void OnEndOpen(IAsyncResult result)
        {
            Print("OnEndOpen");
            this.InnerChannel.EndOpen(result);
        }

        protected override void OnOpen(TimeSpan timeout)
        {
            Print("OnOpen");
            this.InnerChannel.Open(timeout);
        }

        #endregion
    }
}
