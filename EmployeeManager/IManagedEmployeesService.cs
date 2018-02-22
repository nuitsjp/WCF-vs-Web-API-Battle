using System.Collections.Generic;
using System.ServiceModel;

namespace EmployeeManager
{
    [ServiceContract]
    public interface IManagedEmployeesService
    {
        [OperationContract]
        IList<ManagedEmployee> GetManagedEmployees();
    }
}