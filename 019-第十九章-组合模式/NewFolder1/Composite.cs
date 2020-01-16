using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _019_第十九章_组合模式
{
    class Composite : Component
    {
        public List<Component> children;
        public Composite(string name) : base(name)
        {
            children = new List<Component>();
        }

        public override void Add(Component c)
        {
            children.Add(c);
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new string('_', depth) + name);
            foreach (Component child in children) //这里就是多态，使用父类声明，调用时是子类的方法
            {
                child.Display(depth + 2);
            }
        }

        public override void Remove(Component c)
        {
            children.Remove(c);
        }
    }
}
