using System;

namespace Service
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码和配置文件中的类名“Service1”。
    public class Service1 : IService1
    {
        public string GetData(int value)
        {
            Console.WriteLine("我的Action 方法："+value);
            return string.Format("My Reply!!!You entered: {0}", value);
        }

        public string MyOperatorTest(string inputStr)
        {
            Console.WriteLine("========我的方法行为约束===========");
            return "我写的操作:::"+inputStr;
        }
        public string MySecondOperatorTest(string inputStr)
        {
            Console.WriteLine("========我的方法Second行为约束=====");
            return "我写的操作:::" + inputStr;
        }
        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}
