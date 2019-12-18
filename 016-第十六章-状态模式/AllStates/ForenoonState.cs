using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _016_第十六章_状态模式
{
    class ForenoonState : State
    {
        public override void WriteProgram(Work w)
        {
            if (w.Hour < 12f)
            {
                Console.WriteLine("工作在早上{0}点，状态不错", w.Hour);
            }
            else
            {
                w.SetState(new NoonState());
                w.WriteProgram();
            }
        }
    }
}
