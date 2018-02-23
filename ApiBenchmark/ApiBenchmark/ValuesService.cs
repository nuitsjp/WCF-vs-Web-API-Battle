using System.Collections.Generic;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using ApiBenchmark.Models;
using ApiBenchmark.Properties;
using Newtonsoft.Json;

namespace ApiBenchmark
{
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Required)]
    public class ValuesService : IValuesService
    {
        public IEnumerable<string> Get()
        {
            return new[] { "value1", "value2" };
        }

        public IEnumerable<SalesOrderHeaderDetail> GetSalesOrderHeaderDetails(string id)
        {
            string json;
            switch (int.Parse(id))
            {
                case 100:
                    json = Resources.SalesOrderHeaderDetail_100;
                    break;
                case 1000:
                    json = Resources.SalesOrderHeaderDetail_1000;
                    break;
                case 10000:
                    json = Resources.SalesOrderHeaderDetail_10000;
                    break;
                case 500:
                    json = Resources.SalesOrderHeaderDetail_500;
                    break;
                case 5000:
                    json = Resources.SalesOrderHeaderDetail_5000;
                    break;
                default:
                    json = Resources.SalesOrderHeaderDetail_100;
                    break;
            }
            return JsonConvert.DeserializeObject<List<SalesOrderHeaderDetail>>(json);

        }
    }
}