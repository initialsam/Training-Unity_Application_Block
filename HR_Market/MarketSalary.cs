using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Market
{
     public class MarketSalary
    {
        private IMarketSalaryFormula _salaryFormula;

        //public SalaryV1(SalaryFormula salaryFormula)
        //{
        //    this._salaryFormula = salaryFormula;
        //}

        public MarketSalary(IMarketSalaryFormula salaryFormula)
        {
            this._salaryFormula = salaryFormula;
        }

        public int Calculate(int workHour, int hourPay, int dayOffHour)
        {
            return _salaryFormula.Execute(workHour,hourPay,dayOffHour);
        }

    }

    public interface IMarketSalaryFormula
    {
        int Execute(int workHour, int hourPay, int dayOffHour);
    }

    public class MarketSalaryFormula : IMarketSalaryFormula
    {
        public int Execute(int workHour, int hourPay, int dayOffHour)
        {
            return ((workHour - dayOffHour) * hourPay)+100;
        }
    }

    public class MarketBossSalaryFormula : IMarketSalaryFormula
    {
        public int Execute(int workHour, int hourPay, int dayOffHour)
        {
            return (workHour - dayOffHour) * (hourPay*3) ;
        }
    }
}
