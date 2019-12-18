using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _016_第十六章_状态模式
{
    class RelaxState : State
    {
        public override void WriteProgram(Work w)
        {
            Console.WriteLine("我在家好好休息着呢!");
        }
    }
}
