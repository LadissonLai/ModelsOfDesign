using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _016_第十六章_状态模式
{
    class SleepingState : State
    {
        public override void WriteProgram(Work w)
        {

            if (w.TaskFinish)
            {
                Console.WriteLine("工作完成，我下班了！");
                w.SetState(new RelaxState());
                w.WriteProgram();
                return;
            }
            if (w.Hour < 23f)
            {
                Console.WriteLine("工作在晚上{0}点，不行了今晚就睡在公司了！", w.Hour);
            }
        }
    }
}
