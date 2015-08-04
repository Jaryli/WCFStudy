using System.Runtime.Serialization;

namespace ServiceEmployRest
{
    [DataContract(Namespace = "http://www.cnblogs.com/jaryleely/")]
    public class Employee
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string EmployName { get; set; }
        [DataMember]
        public string Sex { get; set; }
        [DataMember]
        public string Address { get; set; }

        public override string ToString()
        {
            return string.Format("编号：{0}，姓名：{1}，年龄{2}，地址：{3}", Id, EmployName, Sex, Address);
        }
    }
}
