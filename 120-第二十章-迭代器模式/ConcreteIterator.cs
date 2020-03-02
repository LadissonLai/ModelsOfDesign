using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _120_第二十章_迭代器模式
{
    class ConcreteIterator : Iterator
    {
        private int current = 0;
        private ConcreteAggregate aggregate;

        public ConcreteIterator(ConcreteAggregate aggregate)
        {
            this.aggregate = aggregate;
        }

        public override object Current
        {
            get
            {
                return aggregate[current];
            }
        }

        public override bool IsDone()
        {
            return current >= aggregate.Count ? true : false;
        }

        public override bool MoveNext()
        {
            if ((current + 1) < aggregate.Count)
            {
                current++;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
