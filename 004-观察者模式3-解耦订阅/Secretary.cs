using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_观察者模式3_解耦订阅
{
    delegate void EventHandler(string e);
    class Secretary : ISubjectSelf
    {
        public event EventHandler Update;
        public string SubjectState { get; set; }
        public void Notify()
        {
            Update(SubjectState);
        }

        public string Name { get; set; }

 
    }
}
