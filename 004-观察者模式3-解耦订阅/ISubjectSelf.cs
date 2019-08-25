using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_观察者模式3_解耦订阅
{
    interface ISubjectSelf
    {
        void Notify();
        string SubjectState { get; set; }
    }
}
