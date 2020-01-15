using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _017_适配器模式
{
    class Program
    {
        static void Main(string[] args)
        {
            ForeignCenter ym = new ForeignCenter() { Name = "姚明" };
            Forward bdr = new Forward() { Name = "巴蒂尔" };
            Guard mkgld = new Guard() { Name = "麦克格雷迪" };
            Translator translator = new Translator(ym);

            bdr.Attack();
            mkgld.Defense();
            translator.Attack();
            Console.ReadKey();
        }
    }
}
