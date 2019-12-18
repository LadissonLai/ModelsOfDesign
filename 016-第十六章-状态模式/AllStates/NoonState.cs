using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _016_第十六章_状态模式
{
    class NoonState : State
    {
        public override void WriteProgram(Work w)
        {
            if (w.Hour < 13f)
            {
                Console.WriteLine("工作在中午{0}点,很困！", w.Hour);

            }
            else
            {
                w.SetState(new AfternoonState());
                w.WriteProgram();
            }
        }
    }
}
