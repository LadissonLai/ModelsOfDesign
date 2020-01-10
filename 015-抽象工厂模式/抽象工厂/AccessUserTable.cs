using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _015_抽象工厂模式
{
    class AccessUserTable : IUserTable
    {
        public void GetUser(int id)
        {
            Console.WriteLine("根据id，查询Access中的数据");
        }

        public void Insert(User user)
        {
            Console.WriteLine("在Access中插入,user数据");
        }
    }
}
