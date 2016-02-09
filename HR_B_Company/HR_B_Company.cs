using HR_Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_B_Company
{
    public class B_CompanyFormula : ISalaryFormula
    {
        public int Execute(int workHour, int hourPay, int dayOffHour)
        {
            return ((workHour - dayOffHour) * hourPay)+200;
        }
    }

    public class B_CompanyBossFormula : ISalaryFormula
    {
        public int Execute(int workHour, int hourPay, int dayOffHour)
        {
            return (workHour - dayOffHour) * (hourPay*2)+2000 ;
        }
    }
}
