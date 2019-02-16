using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace WebApiPure.ApiFilterCompletement
{
    /// <summary>
    /// Web API Filter complementation: Record log before and after invoking method.
    /// referenece: 
    /// ActionFilterAttribute Class -> msdn
    /// https://www.tutorialsteacher.com/webapi/web-api-filters
    /// </summary>
    public class LogAttribute: ActionFilterAttribute
    {
        public LogAttribute()
        {

        }

        public override void OnActionExecuting(HttpActionContext actionContext)
        {
            //get the ip address of the client.
            string clientIp= HttpContext.Current != null ? HttpContext.Current.Request.UserHostAddress : "";
            System.Diagnostics.Trace.WriteLine(string.Format("Before:Action Method {0} executing at {1},arguements:{2},ip:{3}", 
                actionContext.ActionDescriptor.ActionName, DateTime.Now.ToShortDateString(), GetJsonText(actionContext.ActionArguments), clientIp), 
                "Web API Logs"); 
        }

        public override void OnActionExecuted(HttpActionExecutedContext actionExecutedContext)
        {
            //get the ip address of the client.
            string clientIp = HttpContext.Current != null ? HttpContext.Current.Request.UserHostAddress : "";
            System.Diagnostics.Trace.WriteLine(string.Format("After:Action Method {0} executed at {1},Response:{2},clientIP:{3}", 
                actionExecutedContext.ActionContext.ActionDescriptor.ActionName, DateTime.Now.ToShortDateString(), GetJsonText(actionExecutedContext.Response.Content),clientIp), 
                "Web API Logs"); 
        }

        private string GetJsonText(object obj)
        {
            return JsonConvert.SerializeObject(obj);
        }

    }


}