using HR_Base;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_UnityConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            int money;
            using (IUnityContainer container = new UnityContainer())
            {
                UnityConfigurationSection section = 
                    (UnityConfigurationSection)ConfigurationManager.GetSection("unity");
               
                section.Configure(container,"Employee");
  
                Salary ms1 = container.Resolve<Salary>();

                money = ms1.Calculate(80,100,1);
                Console.WriteLine("Unity =>" + money);

                section.Configure(container,"Boss");
  
                ms1 = container.Resolve<Salary>();

                money = ms1.Calculate(80,100,1);
                Console.WriteLine("Boss =>" + money);
         
                Console.ReadKey();
               
            }
        }
    }
}
