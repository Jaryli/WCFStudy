using System;
using System.ServiceModel.Dispatcher;

namespace Service
{
   public class MyParameterInspector:IParameterInspector
    {
        public int MaxLength { get; set; }

        public MyParameterInspector(int maxLength)
        {
            MaxLength = maxLength;
        }

        public void AfterCall(string operationName, object[] outputs, object returnValue, object correlationState)
        {
            
        }

        public object BeforeCall(string operationName, object[] inputs)
        {
            if (operationName == "MyOperatorTest")
            {
                foreach (var item in inputs)
                {
                    if (item.ToString().Length > MaxLength)
                    {
                        Console.WriteLine("biubiu！！输入的长度超过"+MaxLength+"啦！！！");
                    }
                }
            }
            return null;
        }
    }
}
