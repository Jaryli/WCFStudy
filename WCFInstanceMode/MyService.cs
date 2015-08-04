using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFInstanceMode
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码和配置文件中的类名“MyService”。
    [ServiceBehavior(InstanceContextMode=InstanceContextMode.PerCall)]
    public class MyService : IMyService,IDisposable
    {
        public MyService()
        {
            Console.WriteLine("Constractor:{0}",this.GetHashCode());
        }
        [OperationBehavior]
        public string DoWork()
        {
            Console.WriteLine("SessionID:{0}", OperationContext.Current.SessionId);
            return string.Format("我的工作::{0}",OperationContext.Current.SessionId);

        }
        public void Dispose()
        {
            Console.WriteLine("Dispose!");
        }
    }
}
