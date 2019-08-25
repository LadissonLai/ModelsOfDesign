using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_观察者模式2
{
    class StockObserver
    {
        public StockObserver(string name, Secretary secretary)
        {
            Name = name;
            this.secretary = secretary;
        }

        public string Name { get; set; }
        public Secretary secretary { get; set; }
        public void Update()
        {
            Console.WriteLine("老板的状态是{0}，{1}停止玩股票",secretary.SubjectState,Name);
        }
    }
}
