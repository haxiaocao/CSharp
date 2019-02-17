using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace WebApiPure.Controller
{
    public class HelloController: ApiController
    {
        //[Route("api/DownloadPdfFile/{id}")]
        //[HttpGet]
        public string Get()
        {
            return "Hello World";
        }
    }
}