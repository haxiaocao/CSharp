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
            System.Diagnostics.Trace.WriteLine(string.Format("Before:Action Method {0} executing at {1},arguements:{2}", 
                actionContext.ActionDescriptor.ActionName, DateTime.Now.ToShortDateString(), GetJsonText(actionContext.ActionArguments)), 
                "Web API Logs"); 
        }

        public override void OnActionExecuted(HttpActionExecutedContext actionExecutedContext)
        {
            System.Diagnostics.Trace.WriteLine(string.Format("After:Action Method {0} executed at {1},Response:{2}", 
                actionExecutedContext.ActionContext.ActionDescriptor.ActionName, DateTime.Now.ToShortDateString(), GetJsonText(actionExecutedContext.Response.Content)), 
                "Web API Logs"); 
        }

        private string GetJsonText(object obj)
        {
            return JsonConvert.SerializeObject(obj);
        }

    }


}