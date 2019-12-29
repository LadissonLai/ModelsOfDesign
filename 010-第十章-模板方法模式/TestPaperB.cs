using System;
using System.Collections.Generic;
using System.Text;

namespace _010_第十章_模板方法模式
{
    class TestPaperB : TestPaper
    {
        public override string Answer1()
        {
            return "C";
        }

        public override string Answer2()
        {
            return "B";
        }

        public override string Answer3()
        {
            return "A";
        }
    }
}
