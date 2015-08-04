using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Messaging;
namespace ServiceMSMQ
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码和配置文件中的类名“MsmqService”。
    public class MsmqService : IMsmqService
    {
        public void DoWork()
        {
            using (MessageQueue mq = new MessageQueue(@".\Private$\myqueue"))
            {
                mq.Label = "jarylabel";
                mq.Send("MSMQ Private Message", "test message"); // 发送消息
                System.Messaging.Message msg = mq.Receive();
                string strinfo = msg.Body.ToString();
                mq.Label = strinfo;
            }
        }
    }
}
