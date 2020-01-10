using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _015_抽象工厂模式
{
    class AccessDeprtTable : IDepartment
    {
        public void GetDepartment(int id)
        {
            Console.WriteLine("根据id，获取access的department数据");
        }

        public void Insert(Department deprt)
        {
            Console.WriteLine("在Access中插入，depart数据");
        }
    }
}
