using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006_第六章_装饰模式
{
    /// <summary>
    /// 内裤外穿
    /// </summary>
    class UnderpantsOut : Decorator
    {
        public override void Show()
        {
            Console.Write("内裤外穿 ");
            base.Show();
        }
    }
}
