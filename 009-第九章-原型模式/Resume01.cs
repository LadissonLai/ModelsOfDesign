using System;
using System.Collections.Generic;
using System.Text;

namespace _009_第九章_原型模式
{
    class Resume01 : ICloneable
    {
        public string Name { get; set; }
        public string Sex { get; set; }

        public int Age { get; set; }

        public Resume01(string name, int age, string sex)
        {
            Name = name;
            this.Age = age;
            this.Sex = sex;
        }

        public void Display()
        {
            Console.WriteLine("姓名:{0}", Name);
            Console.WriteLine("年龄:{0}", Age);
            Console.WriteLine("性别:{0}", Sex);
        }

        public void SetSex(string sex)
        {
            this.Sex = sex;
        }

        public object Clone()
        {
            return (object)this.MemberwiseClone();
        }
    }
}
