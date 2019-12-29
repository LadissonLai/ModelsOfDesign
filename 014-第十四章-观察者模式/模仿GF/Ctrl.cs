using System;
using System.Collections.Generic;
using System.Text;

namespace _014_第十四章_观察者模式
{
    public class Ctrl
    {
        private EventHandler handler;
        private static Ctrl instance;
        private List<EventArgs> eventArgsList;
        public static Ctrl Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Ctrl();
                    return instance;
                }
                else
                {
                    return instance;
                }
            }
        }
        private Ctrl()
        {
            eventArgsList = new List<EventArgs>
            {
                new TeacherComeEventArgs()
            };
        }

        public void Subscribe(int id, EventHandler h)
        {
            handler += h;
        }

        public void Fire(Object sender, EventArgs e)
        {
            handler(sender, e);
        }

        public T Acquire<T>() where T : EventArgs
        {
            foreach (var item in eventArgsList)
            {
                if(item is T)
                {
                    return item as T;
                }
            }
            return null;
        }

    }
}
