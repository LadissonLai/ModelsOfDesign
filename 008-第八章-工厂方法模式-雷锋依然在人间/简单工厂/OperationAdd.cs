using System;
using System.Collections.Generic;
using System.Text;

namespace _008_第八章_工厂方法模式_雷锋依然在人间
{
    class OperationAdd : Operarion
    {
        public override double GetResult()
        {
            return NumberA + NumberB;
        }
    }
}
