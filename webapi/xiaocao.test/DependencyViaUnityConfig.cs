using Microsoft.Practices.Unity.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace xiaocao.test
{
    class DependencyViaUnityConfig
    {
        //https://docs.microsoft.com/en-us/previous-versions/msp-n-p/dn507421(v%3dpandp.30)
        // unity dll version ; sections in the appsettings position. -> configSections 在app.config的第一个节点。
        static void Main(string[] args)
        {
            UnityContainer container = new UnityContainer();//创建容器
            UnityConfigurationSection configuration = (UnityConfigurationSection)ConfigurationManager.GetSection(UnityConfigurationSection.SectionName);
            configuration.Configure(container, "defaultContainer");
            Employee emp = container.Resolve<Employee>();
            emp.DoingConnection();

            Console.ReadKey();
        }
    }
}
