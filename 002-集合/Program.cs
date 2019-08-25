using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_集合
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList animals = new ArrayList();
            animals.Add(1);
            animals.Add("悟空");
            Animal cat = new Animal();
            animals.Add(cat);
            foreach (var item in animals)
            {
                Console.WriteLine(item);
            }
            animals.RemoveAt(0);
            Console.WriteLine(animals[0]);

            Console.ReadKey();

        }
    }
}
