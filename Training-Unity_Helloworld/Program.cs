using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Training_Unity_Helloworld;
using Microsoft.Practices.Unity.Configuration;
using System.Configuration;

namespace Training_Unity_HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //Unity 入門 (1)
            //重點new Unity 的 DI容器
            Console.WriteLine("================Unity 入門 (1)==============================");
            var container = new UnityContainer();
            IHelloWorld helloWorld = container.Resolve<HelloWorld>();
            helloWorld.Say();

            //Unity 入門 (2)(3)
            //Unity 註冊型別
            //Unity 在解析物件時，會知道應該用 HelloInCHT 來建立物件，而不是 HelloWorld。
            Console.WriteLine("================Unity 入門 (2)(3)==============================");
            container.RegisterType<IHelloWorld, HelloWorldCHT>();
            helloWorld = container.Resolve<IHelloWorld>();
            helloWorld.Say();

            container.RegisterType<IHelloPG, HelloPG>();
            helloWorld = container.Resolve<IHelloWorld>();
            helloWorld.Go();

            IHelloPG helloPG = container.Resolve<IHelloPG>();
            helloPG.Work();

            //Unity 入門 (4)
            //RegisterType 會後蓋前
            //明確指定預設對應
            Console.WriteLine("================Unity 入門 (4)==============================");
            container.RegisterType<IHelloWorld, HelloWorld>();
            container.RegisterType<IHelloWorld, HelloWorldCHT>("CHT");
 
            IHelloWorld hello1 = container.Resolve<IHelloWorld>();
            IHelloWorld hello2= container.Resolve<IHelloWorld>("CHT");
            hello1.Go();
            hello2.Go();
            

            //Unity 入門 (5)
            Console.WriteLine("================Unity 入門 (5)==============================");
            var containerConfig = new UnityContainer();
            containerConfig.LoadConfiguration();
            IHelloWorld hello3 = container.Resolve<IHelloWorld>();
            IHelloWorld hello4 = container.Resolve<IHelloWorld>("CHT");
            hello3.Say();
            hello4.Say();




            Console.ReadKey();
        }
    }

   
}
