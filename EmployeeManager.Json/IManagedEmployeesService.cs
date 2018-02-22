using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace EmployeeManager
{
    [ServiceContract]
    public interface IManagedEmployeesService
    {
        [OperationContract]
        [WebGet(RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        IList<ManagedEmployee> GetManagedEmployees();
    }
}