using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_观察者模式3_解耦订阅
{
    class Program
    {
        static void Main(string[] args)
        {
            NBAObserver tongshi1 = new NBAObserver("金城武");
            NBAObserver tongshi2 = new NBAObserver("黄晓明");

            Secretary secretary = new Secretary();

            tongshi1.Subscribe(secretary,NBAStop1);
            tongshi2.Subscribe(secretary, NBAStop2);
            secretary.SubjectState = "老板来了";

            secretary.Notify();
            Console.ReadKey();
        }

        private static void NBAStop1(string e)
        {
            Console.WriteLine($"{e},停止看NBA");
        }

        private static void NBAStop2(string e)
        {
            Console.WriteLine($"{e},停止看NBA");
        }


    }
}
