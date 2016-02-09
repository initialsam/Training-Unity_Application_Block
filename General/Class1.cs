using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General
{
    public class SalaryV1
    {
        private ISalaryFormula _salaryFormula;

        //public SalaryV1(SalaryFormula salaryFormula)
        //{
        //    this._salaryFormula = salaryFormula;
        //}

        public SalaryV1(ISalaryFormula salaryFormula)
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
            return (workHour - dayOffHour) * (hourPay*2) ;
        }
    }
}
