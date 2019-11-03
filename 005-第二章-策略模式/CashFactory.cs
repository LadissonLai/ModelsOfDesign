using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_第二章_策略模式
{
    class CashFactory
    {
        public static CashSuper CreateCashAccept(string type)
        {
            CashSuper cashSuper = null;
            switch (type)
            {
                case "正常收费":
                    cashSuper = new CashNormal();
                    break;
                case "满400减50":
                    cashSuper = new CashReturn("400", "50");
                    break;
                case "打八折":
                    cashSuper = new CashRebate("0.8");
                    break;
                case "打五折":
                    cashSuper = new CashRebate("0.5");
                    break;
            }
            return cashSuper;
        }
    }
}
