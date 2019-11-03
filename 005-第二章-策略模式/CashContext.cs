using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_第二章_策略模式
{
    class CashContext
    {
        private CashSuper cashSuper;
        private string type;
        
        public CashContext(string type)
        {
            this.type = type;
        }

        private CashSuper SelectAlgorithm()
        {
            switch (type)
            {
                case "打八折":
                    cashSuper = new CashRebate("0.8");
                    break;
                case "正常收费":
                    cashSuper = new CashNormal();
                    break;
                case "满400减50":
                    cashSuper = new CashReturn("400", "50");
                    break;
                case "打五折":
                    cashSuper = new CashRebate("0.5");
                    break;
            }
            return cashSuper;
        }

        public double GetResult(double money)
        {
            double result = SelectAlgorithm().AcceptCash(money);
            return result;
        }
    }
}
