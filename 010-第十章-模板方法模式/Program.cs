using System;

namespace _010_第十章_模板方法模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ShowResult();

            Console.ReadKey();
        }

        static void ShowResult()
        {
            TestPaper stu1 = new TestPaperA();
            TestPaperB stu2 = new TestPaperB();
            Console.WriteLine("我是学生1，我的回答是：");
            stu1.AnswerAllQuestion();

            Console.WriteLine("我是学生2，我的回答是：");
            stu2.AnswerAllQuestion();
        }
    }
}
