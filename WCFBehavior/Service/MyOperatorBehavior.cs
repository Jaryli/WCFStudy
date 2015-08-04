using System;
using System.ServiceModel.Channels;
using System.ServiceModel.Description;
using System.ServiceModel.Dispatcher;

namespace Service
{
    public class MyOperatorBehaviorAttribute : Attribute, IOperationBehavior
    {
        public int MaxLength { get; set; }
        public void AddBindingParameters(OperationDescription operationDescription, BindingParameterCollection bindingParameters)
        {
           
        }

        public void ApplyClientBehavior(OperationDescription operationDescription, ClientOperation clientOperation)
        {
            
        }

        public void ApplyDispatchBehavior(OperationDescription operationDescription, DispatchOperation dispatchOperation)
        {
            dispatchOperation.ParameterInspectors.Add(new MyParameterInspector(MaxLength));
        }

        public void Validate(OperationDescription operationDescription)
        {
            Console.WriteLine("我是操作行为：：：："+operationDescription.Behaviors[0]);
        }
    }
}
