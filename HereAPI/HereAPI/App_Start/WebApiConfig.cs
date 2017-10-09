using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web;

namespace HereAPI
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            var origin = "";
            if (HttpContext.Current.IsDebuggingEnabled)
            {
                origin = "*";
            }
            else
            {
                origin = "http://client.larkyo.com";

            }
            var cors = new EnableCorsAttribute(origin, "*", "*");
            config.EnableCors(cors);


            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
