using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_观察者模式1
{
    //实现抽象的
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteSubject Secretary = new ConcreteSubject();
            
            ConcreteObserver xiaowang = new ConcreteObserver(Secretary, "小王");
            ConcreteObserver dawang = new ConcreteObserver(Secretary, "大王");
            Secretary.Attach(xiaowang);
            Secretary.Attach(dawang);

            Secretary.SubjectState = "经理来了";
            Secretary.Notify();
            Console.ReadKey();
        }
    }
}
