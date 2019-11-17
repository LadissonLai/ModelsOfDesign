using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006_第六章_装饰模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Person xc = new Person("小菜");
            Animal tly = new Animal("唐老鸭");
            Person xt = new Person("薛涛");
            

            BigTrouser dck = new BigTrouser(); //大衩裤
            UnderpantsOut nkwc = new UnderpantsOut(); //内裤外穿
            LXclothes lgclothes = new LXclothes(); //老公衣服
            DecoratorOutline decorator = new DecoratorOutline();

            dck.SetComponent(xc);
            nkwc.SetComponent(dck);
            decorator.SetComponent(nkwc);
            decorator.Show();

            nkwc.SetComponent(tly);
            decorator.SetComponent(nkwc);
            decorator.Show();

            lgclothes.SetComponent(xt);
            decorator.SetComponent(lgclothes);
            decorator.Show();


            Console.ReadKey();
        }
    }
}
