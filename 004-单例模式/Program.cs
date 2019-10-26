using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_单例模式
{
    class Program
    {
        static void Main(string[] args)
        {
            //第一种 单例模式
            CustomUIForm Instance = CustomUIForm.Create();
            CustomUIForm.Instance.OpenUIForm("----第一种----");

            CustomUIForm2.Instance.OpenUIForm("----第二种----");
            Console.ReadKey();

        }

    }
}
