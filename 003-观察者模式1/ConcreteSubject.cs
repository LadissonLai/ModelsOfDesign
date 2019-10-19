using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_观察者模式1
{
    class ConcreteSubject:Subject
    {
        //主题状态
        private string subjectState;
        public string SubjectState
        {
            get
            {
                return subjectState;
            }
            set
            {
                subjectState = value;
                
            }
        }

    }
}
