using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _105_反射学习
{
    class ReflectionClass : IMyinterface
    {
        public string name;
        public string MyProperty1 { get; set; }
        public string MyProperty2 { get; set; }

        public ReflectionClass()
        {
            name = "反射";
        }
        public string Fly()
        {
            return "I am flying!";
        }

        public void MyFunc(string name)
        {
            Console.WriteLine(name);
        }

        private void MyPrivateFunc()
        {

        }
    }
}
