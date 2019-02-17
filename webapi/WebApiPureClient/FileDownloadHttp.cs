using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace WebApiPureClient
{
    class FileDownloadHttp
    {
        /// <summary>
        /// reference: https://stackoverflow.com/questions/307688/how-to-download-a-file-from-a-url-in-c
        /// 这种方式纯粹是通过webapi的形式来做的，因此需要提前知道方法的参数名称，在url中体现
        /// 如：url: http://localhost:63324/FileDownload?filename=   filename:111.txt
        /// </summary>
        /// <param name="url"></param>
        /// <param name="fileName"></param>
        /// <param name="fileName">需要保存的本地文件夹，文件名不变</param>
        public static void DownloadFile(string url, string fileName, string dir=null)
        {
            // Create a new WebClient instance.
            using (WebClient myWebClient = new WebClient())
            {
                string myStringWebResource = url + fileName;
                string path = dir == null ? fileName : System.IO.Path.Combine(dir,fileName);
                myWebClient.DownloadFile(myStringWebResource, path);
            }
        }
    }
}
