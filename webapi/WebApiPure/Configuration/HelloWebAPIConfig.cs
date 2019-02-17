using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace WebApiPure.Configuration
{
    public class HelloWebAPIConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API routes
            config.MapHttpAttributeRoutes();

            ////here you can add your custom api route configuration.
            ////一般情况下不需要这样做，设置一个default 够用了。
            //config.Routes.MapHttpRoute(
            //name: "School",
            //routeTemplate: "api/myschool/{id}",
            //defaults: new { controller = "school", id = RouteParameter.Optional },
            //constraints: new { id = "/d+" }
            //);

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                //routeTemplate: "api/{controller}/{id}",  //remove api prefix is fun .
                //Api/{controller}/{action}/{id}           //specify real method name(I think it is a better choice).
                routeTemplate: "{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}