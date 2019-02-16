using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Xiaocao.Asp.Demo.Controller
{
    public class DataInterface
    {
        public List<PersonInfo> GetPersonList()
        {
            List<PersonInfo> ret = new List<PersonInfo>();

            ret.Add(new PersonInfo { Name="xiao one",Age=15,Position="top 1",Hobby="Ball"});
            ret.Add(new PersonInfo { Name = "xiao two", Age = 25, Position = "top 2", Hobby = "Ball" });
            ret.Add(new PersonInfo { Name = "xiao three", Age = 35, Position = "top 3", Hobby = "Ball" });

            return ret;
        }
    }
}