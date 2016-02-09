using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Base
{
    public class Salary
    {
        private ISalaryFormula _salaryFormula;

        public Salary(ISalaryFormula salaryFormula)
        {
            this._salaryFormula = salaryFormula;
        }

        public int Calculate(int workHour, int hourPay, int dayOffHour)
        {
            return _salaryFormula.Execute(workHour,hourPay,dayOffHour);
        }

    }

    public interface ISalaryFormula
    {
        int Execute(int workHour, int hourPay, int dayOffHour);
    }

    public class SalaryFormula : ISalaryFormula
    {
        public int Execute(int workHour, int hourPay, int dayOffHour)
        {
            return (workHour - dayOffHour) * hourPay;
        }
    }

    public class BossSalaryFormula : ISalaryFormula
    {
        public int Execute(int workHour, int hourPay, int dayOffHour)
        {
            return (workHour - (dayOffHour * 0)) * hourPay;
        }
    }
}
