using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _120_第二十章_迭代器模式
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteAggregate passengers = new ConcreteAggregate();
            passengers[0] = "小菜";
            passengers[1] = "大鸟";
            passengers[2] = "行李";
            passengers[3] = "老外";
            passengers[4] = "公交内部员工";
            passengers[5] = "小偷";

            Iterator iterator = passengers.GetIterator();
            
            while (!iterator.IsDone())
            {
                Console.WriteLine(iterator.Current);
                iterator.MoveNext();
            }

            Console.ReadKey();
        }
    }
}
