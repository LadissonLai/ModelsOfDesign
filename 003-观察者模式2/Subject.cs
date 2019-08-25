using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_观察者模式2
{
    interface Subject
    {
        void Notify();
        string SubjectState { get; set; }
    }
}
