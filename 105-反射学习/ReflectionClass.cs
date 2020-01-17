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
        public int ID;
        public string MyProperty1 { get; set; }
        public string MyProperty2 { get; set; }

        public ReflectionClass()
        {
            name = "反射类";
            ID = GetHashCode();
        }
        public string Fly()
        {
            return "I am flying!";
        }

        public void MyPublicFunc(string content)
        {
            Console.WriteLine(content);
        }

        private void MyPrivateFunc()
        {
            
        }
    }
}
