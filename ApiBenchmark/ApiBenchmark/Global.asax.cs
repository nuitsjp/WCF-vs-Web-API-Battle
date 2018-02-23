using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Activation;
using System.Web;
using System.Web.Http;
using System.Web.Routing;

namespace ApiBenchmark
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);

            RouteTable.Routes.Add(
                new ServiceRoute("ValuesService",
                    new WebServiceHostFactory(),
                    typeof(ValuesService)));
        }
    }
}
