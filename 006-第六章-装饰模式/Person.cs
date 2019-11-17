using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006_第六章_装饰模式
{
    class Person : Component
    {
        private string name;
        public Person(string name)
        {
            this.name = name;
        }

        public override void Show()
        {
            //Console.Write("穿着");
            Console.WriteLine(string.Format("的{0}", name));
        }

    }
}
