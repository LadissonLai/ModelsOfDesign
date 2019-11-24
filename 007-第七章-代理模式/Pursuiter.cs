using System;
using System.Collections.Generic;
using System.Text;

namespace _007_第七章_代理模式
{
    class Pursuiter : IGiveGifts
    {
        private string mm;
        public Pursuiter(SchoolGirl schoolGirl)
        {
            mm = schoolGirl.Name;
        }
        public void GiveChocolate()
        {
            Console.WriteLine(string.Format("送{0}巧克力", mm));
        }

        public void GiveDoll()
        {
            Console.WriteLine(string.Format("送{0}洋娃娃", mm));
        }

        public void GiveFlower()
        {
            Console.WriteLine(string.Format("送{0}鲜花", mm));
        }
    }
}
