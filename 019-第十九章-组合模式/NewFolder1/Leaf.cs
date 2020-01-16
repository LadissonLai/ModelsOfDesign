using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _019_第十九章_组合模式
{
    class Leaf : Component
    {
        public Leaf(string name) : base(name)
        {

        }

        public override void Add(Component c)
        {
            Console.WriteLine("Can not add a leaf.");
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new string('_', depth) + name);
        }

        public override void Remove(Component c)
        {
            Console.WriteLine("Can not remove a leaf.");
        }
    }
}
