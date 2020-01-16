using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _019_第十九章_组合模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Composite root = new Composite("root");
            root.Add(new Leaf("leafA"));
            root.Add(new Leaf("leafB"));

            Composite compositeX = new Composite("CompositeX");
            compositeX.Add(new Leaf("leafXA"));
            compositeX.Add(new Leaf("leafXB"));
            root.Add(compositeX);

            Composite compositeY = new Composite("CompositeY");
            compositeX.Add(compositeY);

            compositeY.Add(new Leaf("leafXYA"));

            Leaf leafC = new Leaf("leafC");
            root.Add(leafC);

            root.Display(1);

            Console.ReadKey();
        }
    }
}
