using System;
using System.Collections.Generic;
using System.Text;

namespace _010_第十章_模板方法模式
{
    abstract class TestPaper
    {
        public void Question1()
        {
            Console.WriteLine("这是第一个题目，你的答案是：{0}", Answer1());
        }
        public void Question2()
        {
            Console.WriteLine("这是第二个题目，你的答案是：{0}", Answer2());
        }
        public void Question3()
        {
            Console.WriteLine("这是第三个题目，你的答案是：{0}", Answer3());
        }

        public virtual string Answer1()
        {
            return "";
        }
        public virtual string Answer2()
        {
            return "";
        }
        public virtual string Answer3()
        {
            return "";
        }

        public void AnswerAllQuestion()
        {
            Question1();
            Question2();
            Question3();
        }
    }
}
