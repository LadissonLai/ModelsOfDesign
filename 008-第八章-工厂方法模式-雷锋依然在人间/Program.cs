using System;

namespace _008_第八章_工厂方法模式_雷锋依然在人间
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //简单工厂模式，判断逻辑写在了工厂里面，但不符合扩展开放-修改封闭原则
            Operarion op1 = SimpleFactory.CreateOperation("+");
            op1.NumberA = 1;
            op1.NumberB = 2;
            double ret1 = op1.GetResult();
            Console.WriteLine("简单工厂运算结果是:" + ret1.ToString());

            //工厂方法模式,判断逻辑写在了客户端
            IFactory factory = new AddFactory();
            Operarion op2 = factory.CreateOperation();
            op2.NumberA = 3;
            op2.NumberB = 2;
            double ret2 = op2.GetResult();
            Console.WriteLine("工厂方法模式运算结果是：" + ret2);

            //抽象工厂模式

            Console.ReadKey();
        }
    }
}
