using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_观察者模式2
{
    class Program
    {
        static void Main(string[] args)
        {
            //创建通知者
            Secretary secretary = new Secretary() { Name = "美少女" };
            //创建两个观察者
            NBAObserver tongshi1 = new NBAObserver("吴所谓", secretary);
            StockObserver tongshi2 = new StockObserver("梅头脑", secretary);

            //女秘书通知老板来了
            secretary.Update += tongshi1.Update;
            secretary.Update += tongshi2.Update;

            secretary.SubjectState = "老板马化腾回来了";
            secretary.Notify();
            Console.ReadKey();
        }
    }
}
