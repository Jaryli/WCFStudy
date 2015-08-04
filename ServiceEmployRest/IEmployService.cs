using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace ServiceEmployRest
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码和配置文件中的接口名“IEmployService”。
    [ServiceContract(Namespace = "http://www.cnblogs.com/jaryleely/")]
    public interface IEmployService
    {
        [WebGet(UriTemplate = "All",ResponseFormat=WebMessageFormat.Json)]
        IEnumerable<Employee> GetAll();

        [WebGet(UriTemplate = "{id}")]
        Employee GetById(string id);

        [WebInvoke(UriTemplate = "/", Method = "PUT")]
        void Create(Employee emp);

        [WebInvoke(UriTemplate = "/", Method = "POST")]
        void Update(Employee emp);

        [WebInvoke(UriTemplate = "/", Method = "DELETE")]
        void Delete(string id);
    }
}
