using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _018_第十八章_备忘录模式
{
    class MemoTaker
    {
        public Memo Memo { get; set; }

        public MemoTaker(Memo m)
        {
            Memo = m;
        }

    }
}
