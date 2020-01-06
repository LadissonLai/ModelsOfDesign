using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _016_第十六章_状态模式_自己做另一种
{
    class Program
    {
        static void Main(string[] args)
        {
            BeginState begin = new BeginState();
            RunningState running = new RunningState();
            EndState end = new EndState();
            FsmSystem fsm = new FsmSystem()
            {
                states =
                {
                    begin,running,end
                }
            };

            fsm.current = fsm.states[0];
            fsm.ChangeState(begin);

            Console.ReadKey();
            
        }
    }
}
