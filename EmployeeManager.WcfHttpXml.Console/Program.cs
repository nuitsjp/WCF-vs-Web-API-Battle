using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManager.WcfHttpXml.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var f = new ChannelFactory<IManagedEmployeesService>("ManagedEmployeesService"))
            {
                var service = f.CreateChannel();
                MeasuringInstrument.Measure(() => service.GetManagedEmployees());
            }
        }
    }
}
