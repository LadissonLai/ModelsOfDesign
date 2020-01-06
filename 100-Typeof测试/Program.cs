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
            Test instance01 = new Test();
            Test instance02 = new Test();
            Console.WriteLine(instance01.GetType());   
            Console.WriteLine(instance02.GetType());
            Console.WriteLine(test);   //这三个方法打印的东西都是一样的，返回的是命名空间.类名

            Console.ReadKey();
        }


    }
}
