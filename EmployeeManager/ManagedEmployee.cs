using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeManager.Properties;
using Newtonsoft.Json;

namespace EmployeeManager
{
    public class ManagedEmployee
    {

        public static Lazy<IList<ManagedEmployee>> ManagedEmployees { get; } = new Lazy<IList<ManagedEmployee>>(() => JsonConvert.DeserializeObject<List<ManagedEmployee>>(Resources.ManagedEmployees));

        public virtual int BusinessEntityID { get; set; }
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
        public virtual int EmailPromotion { get; set; }
        public virtual string NationalIDNumber { get; set; }
        public virtual string LoginID { get; set; }
        public virtual string JobTitle { get; set; }
        public virtual DateTime BirthDate { get; set; }
        public virtual string MaritalStatus { get; set; }
        public virtual string Gender { get; set; }
        public virtual DateTime HireDate { get; set; }
        public virtual bool SalariedFlag { get; set; }
        public virtual short VacationHours { get; set; }
        public virtual short SickLeaveHours { get; set; }
        public virtual bool CurrentFlag { get; set; }
        public virtual decimal Rate { get; set; }
        public virtual byte PayFrequency { get; set; }
        public virtual string GroupName { get; set; }
        public virtual string DepartmentName { get; set; }
        public virtual DateTime StartDate { get; set; }
        public virtual string ShiftName { get; set; }
        public virtual DateTime BusinessEntityModifiedDate { get; set; }
    }
}
