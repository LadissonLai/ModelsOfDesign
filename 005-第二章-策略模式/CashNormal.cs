using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_第二章_策略模式
{
    class CashNormal : CashSuper
    {
        /// <summary>
        /// 返回原价
        /// </summary>
        /// <param name="money"></param>
        /// <returns></returns>
        public override double AcceptCash(double money)
        {
            return money;
        }
    }
}
