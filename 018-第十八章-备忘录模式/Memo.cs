using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _018_第十八章_备忘录模式
{
    class Memo
    {
        public int Vitality { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }

        public Memo(int vit, int atk, int df)
        {
            Vitality = vit;
            Attack = atk;
            Defense = df;
        }
    }
}
