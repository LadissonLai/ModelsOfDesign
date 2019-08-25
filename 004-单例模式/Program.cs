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
            CustomUIForm Instance = CustomUIForm.Create();
            Instance.OpenUIForm("/Assets/UI");
            Console.ReadKey();

        }
    }
}
