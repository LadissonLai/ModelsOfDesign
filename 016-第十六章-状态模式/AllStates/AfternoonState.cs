using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _016_第十六章_状态模式
{
    class AfternoonState : State
    {
        public override void WriteProgram(Work w)
        {
            if (w.Hour < 17f)
            {
                Console.WriteLine("工作在下午{0}点,我是真的困倦!", w.Hour);

            }
            else
            {
                w.SetState(new EveningState());
                w.WriteProgram();
            }
        }
    }
}
