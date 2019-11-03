using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_第二章_策略模式
{
    class CashRebate : CashSuper
    {
        private double moneyRebate = 0d;
        public CashRebate(string moneyRebate)
        {
            this.moneyRebate = Convert.ToDouble(moneyRebate);
            //this.moneyRebate = double.Parse(moneyRebate);
        }
        /// <summary>
        /// 打折，
        /// </summary>
        /// <param name="money"></param>
        /// <returns></returns>
        public override double AcceptCash(double money)
        {
            return money * moneyRebate;
        }
    }
}
