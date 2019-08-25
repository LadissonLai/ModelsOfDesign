using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_观察者模式2
{
    class NBAObserver
    {
        public NBAObserver(string name, Secretary secretary)
        {
            Name = name;
            this.secretary = secretary;
        }

        public string Name { get; set; }
        public Secretary secretary { get; set; }

        public void Update()
        {
            Console.WriteLine($"{secretary.SubjectState},{Name}停止玩股票");
        }
    }
}
