using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace WebApiPureClient
{
    //webapi client 调用webapi服务
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
               // GetHttp();
               //PostHttp();
               PostHttp2(); 
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            Console.WriteLine("测试结束....");
            Console.ReadKey();
        }

        private static void PostHttp2()
        {
            string url = " http://localhost:5623/api/student?id=90";

            //object is the student model : here is mock string(but not worked here. you should get thes string by the object directly.) ;
            string str = WebApiHelper.GetStringByPost(url, "{\"Name\":\"xiaocai01\",\"Age\":18,Company:\"qqali\"}");
            Console.WriteLine("url:{0},\nResponse:{1}", url, str);


        }

        private static void PostHttp()
        {
            string url = "http://localhost:5623/api/student";

            string str = WebApiHelper.GetStringByPost(url, "good.");
            Console.WriteLine("url:{0},\nResponse:{1}", url, str);
        }

        private static void GetHttp()
        {
            //string url = "http://localhost:5623/api/student";
            string url = "http://localhost:63324/api/student?id=9";

            string str = WebApiHelper.GetStringByGet(url);
            Console.WriteLine("url:{0},\nResponse:{1}", url, str);
        }
    }
}
