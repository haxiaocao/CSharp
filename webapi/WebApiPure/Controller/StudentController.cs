using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiPure.Entity;

namespace WebApiPure.Controller
{
    [ApiFilterCompletement.Log]
    public class StudentController : ApiController
    {
        // GET: api/student
        public IEnumerable<string> Get()
        {
            return new string[] { "stu1", "stu2","stu3" ,"stu4","stu5"};
        }

        // GET: api/student/5
        public Student Get(int id)
        {
            return new Student { Age=30,Name=id.ToString(),Company="sh.lcd"};
        }

        // POST: api/student
        public string Post([FromBody]string value)
        {
            return value + "Post method Yeah.";
        }

        public string Post21(int id,[FromBody]Student value)
        {
            if (value==null)
            {
                return "get null value.";
            }
            return id + "Get it."+ value.Name;
        }
        // PUT: api/student/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/student/5
        public void Delete(int id)
        {
        }
    }
}
