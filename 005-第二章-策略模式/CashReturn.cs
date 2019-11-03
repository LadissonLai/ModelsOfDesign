using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_第二章_策略模式
{
    class CashReturn : CashSuper
    {
        private double moneyCondition = 1;
        private double moneyReturn = 0;

        public CashReturn(string moneyCondition,string moneyReturn)
        {
            this.moneyCondition = Convert.ToDouble(moneyCondition);
            this.moneyReturn = Convert.ToDouble(moneyReturn);
        }

        public override double AcceptCash(double money)
        {
            double totalPrices = money - Math.Floor(money / moneyCondition) * moneyReturn;
            return totalPrices;
        }
    }
}
