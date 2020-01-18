using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _103_static关键字测试
{
    class Program
    {
        static void Main(string[] args)
        {
            int Class1Id = TestClass.Id; //虽然main函数是入口，但是先执行了TestClass 中static
            
            TestClass class2 = new TestClass();
            int Class2Id = class2.ClassID;

            Console.WriteLine(Class1Id + " + " + Class2Id);
            Console.ReadKey();
        }
    }
}
