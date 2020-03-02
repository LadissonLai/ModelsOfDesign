using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _120_第二十章_迭代器模式
{
    class ConcreteAggregate : Aggregate
    {
        private IList<object> items = new List<object>();

        public int Count
        {
            get
            {
                return items.Count;
            }
        }

        public override Iterator GetIterator()
        {
            return new ConcreteIterator(this);
        }

        /// <summary>
        /// 索引器，这是一个集合
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public object this[int index]
        {
            get { return items[index]; }
            set { items.Insert(index, value); }
            //set { items[index] = value; } //这个方法会报错，不是很理解
        }

    }
}
