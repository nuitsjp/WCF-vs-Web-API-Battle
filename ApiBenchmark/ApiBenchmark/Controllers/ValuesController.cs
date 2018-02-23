using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ApiBenchmark.Models;
using ApiBenchmark.Properties;
using Newtonsoft.Json;

namespace ApiBenchmark.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new [] { "value1", "value2" };
        }

        // GET api/<controller>/5
        public IEnumerable<SalesOrderHeaderDetail> Get(int id)
        {
            string json;
            switch (id)
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

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}