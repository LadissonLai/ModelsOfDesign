using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_观察者模式3_解耦订阅
{
    interface IObserverSelf
    {
        void Subscribe(Secretary subject, EventHandler eventHandler);
        void UnSubscribe(Secretary subject, EventHandler eventHandler);
    }
}
