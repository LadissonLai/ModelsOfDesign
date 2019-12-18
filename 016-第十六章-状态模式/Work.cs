using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _016_第十六章_状态模式
{
    class Work
    {
        private float hour = 8f;
        private bool isFinish = false;
        private State current = new ForenoonState();
        public State Current
        {
            get
            {
                return current;
            }
            set
            {
                current = value;
            }
        }

        public float Hour
        {
            get
            {
                return hour;
            }
            set
            {
                hour = value;
            }
        }

        public bool TaskFinish
        {
            get
            {
                return isFinish;
            }
            set
            {
                isFinish = value;
            }
        }

        public void SetState(State s)
        {
            current = s;
        }

        public void WriteProgram()
        {
            current.WriteProgram(this);
        }



    }
}
