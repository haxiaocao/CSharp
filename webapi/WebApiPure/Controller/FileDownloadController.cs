using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using System.Web.Http;
using WebApiPure.ApiFilterCompletement;

namespace WebApiPure.Controller
{
    [Log]
    public class FileDownloadController: ApiController
    {
        //[Route("api/myfileupload")]  //you can custom the route template
        //[HttpGet()]
        /// <summary>
        /// download 文件 
        /// usage example: http://localhost:63324/FileDownload?filename=modify-code.pdf
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public HttpResponseMessage GetPdfFile(string fileName)
        {
            if (String.IsNullOrEmpty(fileName))
                return Request.CreateResponse(HttpStatusCode.BadRequest);

            string localFilePath = GetRealPath(fileName);
            if (!File.Exists(localFilePath))
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }

            HttpResponseMessage response = new HttpResponseMessage(HttpStatusCode.OK);
            response.Content = new StreamContent(new FileStream(localFilePath, FileMode.Open, FileAccess.Read));
            response.Content.Headers.ContentDisposition = new System.Net.Http.Headers.ContentDispositionHeaderValue("attachment");
            response.Content.Headers.ContentDisposition.FileName = fileName;
            response.Content.Headers.ContentType = new MediaTypeHeaderValue("application/pdf");

            return response;
        }

        private string GetRealPath(object fileName)
        {
            string fileFolder = System.Web.Hosting.HostingEnvironment.MapPath("~/upload/");
            return fileFolder + fileName;

        }
    }
}