using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace EmployeeManager.WebAPI.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var httpClient = new HttpClient())
            {
                MeasuringInstrument.Measure(() =>
                {
                    var task = httpClient.GetStringAsync("http://ww-webapi.azurewebsites.net/api/ManagedEmployees");
                    task.Wait();
                    var employees = JsonConvert.DeserializeObject<List<ManagedEmployee>>(task.Result);
                    return employees;
                });
            }
        }
    }
}
