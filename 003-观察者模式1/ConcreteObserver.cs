using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_观察者模式1
{
    class ConcreteObserver : Observer
    {
        public ConcreteSubject Subject { get; set; }
        //观察者的信息与状态
        private string name;
        public string ObserverState { get; set; } = "不看NBA了。";


        public ConcreteObserver(ConcreteSubject subject,string name)
        {
            this.Subject = subject;
            this.name = name;
        }

        //更新状态
        public override void Update()
        {
            Console.WriteLine("主题状态改变为：{0}",Subject.SubjectState);
            Console.WriteLine("观察者也改变状态为：{0}", ObserverState);
        }
    }
}
