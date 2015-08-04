using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Channels;
using System.Text;

namespace MyBindingDemo
{
    /// <summary>
    /// 自定义绑定元素
    /// </summary>
    public class SimpleBindingElement : BindingElement
    {
        public SimpleBindingElement()
        {
        }

        public override BindingElement Clone()
        {
            return new SimpleBindingElement();
        }

        public override T GetProperty<T>(BindingContext context)
        {
            Console.WriteLine(typeof(T).Name);
            return context.GetInnerProperty<T>();
        }

        public override IChannelFactory<TChannel> BuildChannelFactory<TChannel>(BindingContext context)
        {
            return new SimpleChannelFactory<TChannel>(context);
        }

        public override IChannelListener<TChannel> BuildChannelListener<TChannel>(BindingContext context)
        {
            return new SimpleChannelListener<TChannel>(context);
        }
    }
}
