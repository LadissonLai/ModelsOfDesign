using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _016_第十六章_状态模式
{
    class ForceOffDutyState : State
    {
        public override void WriteProgram(Work w)
        {
            if (w.Hour >= 20f)
            {
                Console.WriteLine("工作到8点了，强制下班！");
            }
        }
    }
}
