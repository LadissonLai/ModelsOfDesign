using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006_第六章_装饰模式
{
    class Animal : Component
    {
        private string name;
        public Animal(string name)
        {
            this.name = name;
        }
        public override void Show()
        {
            Console.WriteLine(string.Format("的{0}动物", name));
        }
    }
}
