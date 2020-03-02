using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _120_第二十章_迭代器模式
{
    abstract class Iterator
    {
        public abstract object Current { get; }
        public abstract bool MoveNext();

        public abstract bool IsDone();
    }
}
