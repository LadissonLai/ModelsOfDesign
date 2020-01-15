using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _103_static关键字测试
{
    class TestClass
    {
        public static int Id = typeof(TestClass).GetHashCode(); //经过测试，这里是在编译时执行，在进入主程序之前就执行了，内存分配在数据区

        public int ClassID
        {
            get
            {
                return Id;
            }
        }
        public void Func()
        {

        }
    }
}
