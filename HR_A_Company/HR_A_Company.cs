using HR_Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_A_Company
{
    public class A_CompanyFormula : ISalaryFormula
    {
        public int Execute(int workHour, int hourPay, int dayOffHour)
        {
            return ((workHour - dayOffHour) * hourPay)+100;
        }
    }

    public class A_CompanyBossFormula : ISalaryFormula
    {
        public int Execute(int workHour, int hourPay, int dayOffHour)
        {
            return (workHour - dayOffHour) * (hourPay*2)+1000;
        }
    }
}
