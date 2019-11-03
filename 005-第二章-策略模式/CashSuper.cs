using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_第二章_策略模式
{
    abstract class CashSuper
    {
        /// <summary>
        /// 现金收取超类的抽象方法，收取现金，参数为原价，返回便宜价
        /// </summary>
        /// <param name="money"></param>
        /// <returns></returns>
        public abstract double AcceptCash(double money);
    }
}
