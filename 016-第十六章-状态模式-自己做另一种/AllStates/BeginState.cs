using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _016_第十六章_状态模式_自己做另一种
{
    class BeginState : FsmState
    {
        public override void OnEnter(FsmSystem fsmOwner)
        {
            base.OnEnter(fsmOwner);
            Console.WriteLine("进入{0}", typeof(BeginState).ToString());
        }

        public override void OnInit(FsmSystem fsmOwner)
        {
            base.OnInit(fsmOwner);
        }

        public override void OnLeave(FsmSystem fsmOwner)
        {
            base.OnLeave(fsmOwner);
        }

        public override void OnUpdate(FsmSystem fsmOwner)
        {
            base.OnUpdate(fsmOwner);
            Console.WriteLine("离开{0}", typeof(BeginState).ToString());
        }
    }
}
