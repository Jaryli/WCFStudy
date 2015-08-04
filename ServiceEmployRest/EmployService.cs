using System.Collections.Generic;
using System.Linq;

namespace ServiceEmployRest
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码和配置文件中的类名“EmployService”。
    public class EmployService : IEmployService
    {
        public static List<Employee> Lists = new List<Employee> { 
        new Employee{ Id=1,Sex ="Man",Address="江苏无锡",EmployName="张三丰"},
        new Employee{ Id=2,Sex ="Woman",Address="江苏南京",EmployName="张约"}
        };
        public IEnumerable<Employee> GetAll()
        {
            return Lists;
        }

        public Employee GetById(string id)
        {
            return Lists.FirstOrDefault(s => s.Id == int.Parse(id));
        }

        public void Create(Employee emp)
        {
            Lists.Add(emp);
        }

        public void Update(Employee emp)
        {
            Delete(emp.Id.ToString());
            Lists.Add(emp);
        }

        public void Delete(string id)
        {
            var empold = GetById(id);
            if (null != empold)
            {
                Lists.Remove(empold);
            }
        }
    }
}
