using System.ServiceModel.Channels;

namespace MyBindingDemo
{
    /// <summary>
    /// 自定义请求信道
    /// </summary>
    public class SimpleRequestChannel : SimpleChannelBase, IRequestChannel
    {
        public IRequestChannel InnerRequestChannel
        {
            get { return (IRequestChannel)this.InnerChannel; }
        }

        public SimpleRequestChannel(ChannelManagerBase baseManager, IRequestChannel innerChannel)
            : base(baseManager, (ChannelBase)innerChannel)
        {
        }

        public System.IAsyncResult BeginRequest(Message message, System.TimeSpan timeout, System.AsyncCallback callback, object state)
        {
            this.Print("BeginRequest");
            return this.InnerRequestChannel.BeginRequest(message, callback, state);
        }

        public System.IAsyncResult BeginRequest(Message message, System.AsyncCallback callback, object state)
        {
            throw new System.NotImplementedException();
        }

        public Message EndRequest(System.IAsyncResult result)
        {
            throw new System.NotImplementedException();
        }

        public System.ServiceModel.EndpointAddress RemoteAddress
        {
            get { throw new System.NotImplementedException(); }
        }

        public Message Request(Message message, System.TimeSpan timeout)
        {
            throw new System.NotImplementedException();
        }

        public Message Request(Message message)
        {
            throw new System.NotImplementedException();
        }

        public System.Uri Via
        {
            get { throw new System.NotImplementedException(); }
        }
    }
}
