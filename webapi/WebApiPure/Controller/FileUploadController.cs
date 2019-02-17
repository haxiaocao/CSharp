using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace WebApiPure.Controller
{
    /// <summary>
    /// https://stackoverflow.com/questions/10320232/how-to-accept-a-file-post
    /// upload file by post method; and you can do it by using fidder [uploadfile options]
    /// http://localhost:5623/FileUpload
    /// </summary>
    public class FileUploadController : ApiController
    { 
        //[Route("api/myfileupload")]  //you can custom the route 
        [HttpPost()]
        public string UploadFiles()
        {
            int iUploadedCnt = 0;

            // DEFINE THE PATH WHERE WE WANT TO SAVE THE FILES.
            string rootPath=System.Web.Hosting.HostingEnvironment.ApplicationPhysicalPath;
            string uploadPath = Path.Combine(rootPath, "upload");
            if (!Directory.Exists(uploadPath))
            {
                Directory.CreateDirectory(uploadPath);
            }

            string sPath = System.Web.Hosting.HostingEnvironment.MapPath("~/upload/");
            System.Web.HttpFileCollection hostFiles = System.Web.HttpContext.Current.Request.Files;

            // CHECK THE FILE COUNT.
            for (int iCnt = 0; iCnt <= hostFiles.Count - 1; iCnt++)
            {
                System.Web.HttpPostedFile postFile = hostFiles[iCnt];

                if (postFile.ContentLength > 0)
                {
                    // CHECK IF THE SELECTED FILE(S) ALREADY EXISTS IN FOLDER. (AVOID DUPLICATE)
                    if (!File.Exists(sPath + Path.GetFileName(postFile.FileName)))
                    {
                        // SAVE THE FILES IN THE FOLDER.
                        postFile.SaveAs(sPath + Path.GetFileName(postFile.FileName));
                        iUploadedCnt = iUploadedCnt + 1;
                    }
                }
            }

            // RETURN A MESSAGE (OPTIONAL).
            if (iUploadedCnt > 0)
            {
                return iUploadedCnt + " Files Uploaded Successfully";
            }
            else
            {
                return "Upload Failed";
            }
        }
    }
        
}