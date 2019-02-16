using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xiaocao.test
{
    class 
        DebugOperation
    {
        //shift+f9: add watch
        //watch windows or variable windows: modify the variable value.
        // move to the front code to rerun the process.
        //ctrl+F6, ctrl+F4

        static void Main(string[] args)
        {
            Console.ReadKey();

            
            Console.WriteLine("Count:" + args[2]);
            string config1 = ConfigurationManager.AppSettings.Get("config1");
            Console.WriteLine("config1 value:" + config1);

            string config2 = ConfigurationManager.AppSettings.Get("config2");
            Console.WriteLine("config2 value:" + config2);
            Console.ReadKey();

            for (int i = 0; i < 30; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i.ToString());
                }
            }

            Console.ReadKey();
        }
    }
}
