using System;
using System.Collections.Generic;
using System.Text;

namespace _009_第九章_原型模式
{
    class Resume02 : ICloneable
    {
        private string name;
        private int age;
        private string sex;
        private WorkExperience we;
        public string Name
        {
            get
            {
                return name;
            }
        }
        public int Age
        {
            get
            {
                return age;
            }
        }
        public string Sex
        {
            get
            {
                return sex;
            }
        }

        public Resume02()
        {

        }

        public Resume02(string name,int age, string sex,WorkExperience work)
        {
            this.name = name;
            this.age = age;
            this.sex = sex;
            this.we = work;
        }

        public void SetWorkExperience(WorkExperience work)
        {
            this.we = work;
        }

        public object Clone()
        {
            Resume02 clone = new Resume02
            {
                name = this.name,
                age = this.age,
                sex = this.sex,
                we = this.we.Clone() as WorkExperience
            };
            return clone as object;
        }
        public void Display()
        {
            Console.WriteLine("姓名:{0}", Name);
            Console.WriteLine("年龄:{0}", Age);
            Console.WriteLine("性别:{0}", Sex);
            Console.WriteLine("工作经历:时间{0}-{1},在{2}", we.StartTime, we.EndTime, we.Corporation);
        }
    }
}
