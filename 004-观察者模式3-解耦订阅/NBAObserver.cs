using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_观察者模式3_解耦订阅
{
    class NBAObserver : IObserverSelf
    {
        //订阅事件和退订
        public void Subscribe(Secretary subject, EventHandler eventHandler)
        {
            subject.Update += eventHandler;
        }
        public void UnSubscribe(Secretary subject, EventHandler eventHandler)
        {
            subject.Update -= eventHandler;
        }

        //
        public string Name { get; set; }
        public NBAObserver(string name)
        {
            Name = name;
        }
    }
}
