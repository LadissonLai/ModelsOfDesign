using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _016_第十六章_状态模式_自己做另一种
{
    class FsmSystem
    {
        public List<FsmState> states;
        public FsmState current;

        public FsmSystem()
        {
            states = new List<FsmState>();
        }

        public void ChangeState(FsmState nextState)
        {
            current.OnLeave(this);
            current = nextState;
            current.OnEnter(this);
        }
    }
}
