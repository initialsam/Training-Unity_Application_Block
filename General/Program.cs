using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General
{
    class Program
    {
        static void Main(string[] args)
        {

            SalaryV1 s1;
            int money;

            s1 = new SalaryV1(new SalaryFormula());
            money = s1.Calculate(80,100,1);
            Console.WriteLine("Salary =>" + money);
           

            s1 = new SalaryV1(new SalaryFormula());
            money = s1.Calculate(80,100,1);
            Console.WriteLine("Salary =>" + money);
         

            s1 = new SalaryV1(new BossSalaryFormula());
            money = s1.Calculate(80,100,1);
            Console.WriteLine("Salary =>" + money);

            Console.ReadKey();
        }
    }
}
