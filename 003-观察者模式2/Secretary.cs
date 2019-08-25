using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_观察者模式2
{
    delegate void EventHandler();
    class Secretary : Subject
    {
        //EventHandler是一个事件委托类型
        public event EventHandler Update;
        public string SubjectState { get; set; }
        //通知功能
        public void Notify()
        {
            Update();
        }

        public string Name { get; set; }
        
    }
}
