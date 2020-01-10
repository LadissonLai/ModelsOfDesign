using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _100_Typeof测试
{
    class Program
    {
        static void Main(string[] args)
        {
            Type test = typeof(Test);  //变量不允许使用typeof，变量只能用GetType
            string className = test.Namespace + "." + test.Name;
            Console.WriteLine(className);
            Type newType = Type.GetType(className);
            Test activateTest = (Test)Activator.CreateInstance(newType);
            activateTest.Name = "特殊方法创建的类";
            Console.WriteLine(activateTest.Name);
            Test instance01 = new Test();
            Test instance02 = new Test();
            Console.WriteLine(instance01.GetType());   
            Console.WriteLine(instance02.GetType());
            Console.WriteLine(test);   //这三个方法打印的东西都是一样的，返回的是命名空间.类名

            Console.ReadKey();
        }
    }
}
