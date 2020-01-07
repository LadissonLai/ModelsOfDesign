using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _102_子类转父类调子类方法
{
    class Program
    {
        static void Main(string[] args)
        {
            Son lijie = new Son();
            lijie.SonFunc();
            Father f = lijie as Father; //子类转成了父类，一样的是调用子类里面的方法
            if (f != null)
            {
                f.TestFunc();
                
            }
            Console.ReadKey();

        }
    }
}
