using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace xiaocao.test
{
    //install-package unity 
    //https://www.codeproject.com/Articles/988257/Dependency-Injection-using-Unity-container
    //https://www.codeproject.com/Articles/1234518/Dependency-Injection-using-Unity-Resolve-dependenc#_Toc508654964
    class DependencyViaUnity
    {
        static void Main(string[] args)
        {
            var container = new UnityContainer();
            container.RegisterType<IDBAcess,SQLDataAccess>();
            Employee employee = container.Resolve<Employee>();
            employee.DoingConnection();
            
            Console.ReadKey();
        }

    }

    interface IDBAcess
    {
        string Connection { get; set; }
    }

    class SQLDataAccess : IDBAcess
    {
        public string Connection
        {
            get { return "test connection"; }
            set { }
        }
    }
    class Employee
    {
        private readonly IDBAcess dBAcess;

        public string Name { get; set; }
        public Employee(IDBAcess dBAcess)
        {
            this.dBAcess = dBAcess;
        }

        public void DoingConnection()
        {
            Console.WriteLine("DB Connection string :" + dBAcess.Connection);
        }

        //you can also inject Property by using [Dependency] attribute.
        //[Dependency]
        //public PersonalDetails PersonalDetails
        //{
        //    get { return personalDetails; }
        //    set { supplier = personalDetails; }
        //}
    }
}
