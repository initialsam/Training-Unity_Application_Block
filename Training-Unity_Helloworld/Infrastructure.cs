using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Unity_Helloworld
{
    interface IHelloWorld
    {
        void Say();
        void Go();
    }


    class HelloWorld : IHelloWorld
    {
       
        public HelloWorld()
        {
            Console.WriteLine("HelloWorld 建構子");
        }

        public HelloWorld(User user)
        {
            Console.WriteLine("HelloWorld(User user) 建構子");
        }

        public void Say()
        {
            Console.WriteLine("Unity - Hello World!");
        }

        public void Go()
        {
            Console.WriteLine("Unity - Go!");
        }
    }

    class HelloWorldCHT : IHelloWorld
    {
        public HelloWorldCHT()
        {
            Console.WriteLine("HelloInCHT 建構子");
        }

        public void Say()
        {
            Console.WriteLine("Unity - 你好 這世界");
        }

        public void Go()
        {
            Console.WriteLine("Unity - 出發!");
        }
    }

    class User
    {
        //Unity 在建立 User 物件時使用預設建構子
        [InjectionConstructor]
        public User()
        {
            Console.WriteLine("電腦選的");
        }

        //兩個都加 還是以有參數的為主
        //[InjectionConstructor]
        public User(string name = "預設給的")
        {
            Console.WriteLine(name);
        }
    }

    interface IHelloPG
    {
        void Work();
    }

    class HelloPG : IHelloPG
    {
       
        public HelloPG()
        {
            Console.WriteLine("HelloPG 建構子");
        }

        public void Work()
        {
            Console.WriteLine("Unity - Hello PG Work!");
        }
    }
}
