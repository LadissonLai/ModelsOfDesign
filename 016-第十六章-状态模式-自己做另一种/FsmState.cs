using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _016_第十六章_状态模式_自己做另一种
{
    abstract class FsmState
    {

        public int StateID { get; set; }

        public virtual void OnInit(FsmSystem fsmOwner) { }

        public virtual void OnEnter(FsmSystem fsmOwner) { }

        public virtual void OnUpdate(FsmSystem fsmOwner) { }

        public virtual void OnLeave(FsmSystem fsmOwner) { }

    }
}
