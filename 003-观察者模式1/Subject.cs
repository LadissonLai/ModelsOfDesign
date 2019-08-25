using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_观察者模式1
{
    abstract class Subject
    {
        //通知功能
        public void Notify()
        {
            foreach (Observer o in observers)
            {
                o.Update();
            }
        }

        //通知的人员
        private List<Observer> observers = new List<Observer>();
        //观察者添加和删减
        public void Attach(Observer observer)
        {
            observers.Add(observer);
        }
        public void Dettach(Observer observer)
        {
            observers.Remove(observer);
        }

        //通知内容,由具体主题定义
    }
}
