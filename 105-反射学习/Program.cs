using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _105_反射学习
{
    class Program
    {
        static void Main(string[] args)
        {
            ReflectionClass mRF = new ReflectionClass()
            {
                MyProperty1 = "属性1",
                MyProperty2 = "属性2"
            };
            Type myType = mRF.GetType();
            foreach (var item in myType.GetProperties())
            {
                Console.WriteLine(item.Name); //获取属性的名称
                Console.WriteLine(item.GetValue(mRF)); //获取属性的值
            }

            //通过反射实例化一个类的两种方式，todo


            Console.ReadKey();
        }
    }
}
