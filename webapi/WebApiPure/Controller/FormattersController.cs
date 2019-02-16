using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace WebApiPure.Controller
{
    /// <summary>
    /// just to get the media type formatters.
    /// </summary>
    public class FormattersController: ApiController
    {
        public IEnumerable<string> Get()
        {
            IList<string> formatters = new List<string>();

            foreach (var item in GlobalConfiguration.Configuration.Formatters)
            {
                formatters.Add(item.ToString());
            }

            return formatters.AsEnumerable<string>();
        }
    }
}