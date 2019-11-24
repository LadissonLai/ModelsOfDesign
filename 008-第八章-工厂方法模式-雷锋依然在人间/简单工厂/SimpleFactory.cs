using System;
using System.Collections.Generic;
using System.Text;

namespace _008_第八章_工厂方法模式_雷锋依然在人间
{
    class SimpleFactory
    {
        public static Operarion CreateOperation(string oper)
        {
            Operarion operarion = null;
            switch (oper)
            {
                case "+":
                    operarion = new OperationAdd();
                    break;
                case "-":
                    operarion = new OperationSub();
                    break;
                case "/":
                    operarion = new OperationDiv();
                    break;
                default:
                    break;
            }
            return operarion;
        }
    }
}
