using System;

namespace _009_第九章_原型模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ShowResume01();
            Console.WriteLine("++++++++++++++++++++++++++");
            ShowResume02();

            Console.ReadKey();
        }

        static void ShowResume01()
        {
            Resume01 lisa = new Resume01("Lisa", 23, "女");
            Resume01 lisa2 = lisa.Clone() as Resume01;
            Resume01 lisa3 = lisa.Clone() as Resume01;
            lisa.SetSex("不男不女");
            lisa.Display();
            lisa2.Display();
            lisa3.Display();
        }

        static void ShowResume02()
        {
            Resume02 jack = new Resume02("Jack", 25, "男", null);
            jack.SetWorkExperience(new WorkExperience("1997", "2008", "Microsoft"));
            Resume02 jack2 = jack.Clone() as Resume02;
            jack2.SetWorkExperience(new WorkExperience("1997", "2008", "Google"));
            Resume02 jack3 = jack2.Clone() as Resume02;
            jack.Display();
            jack2.Display();
            jack3.Display();
        }
    }
}
