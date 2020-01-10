using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _015_抽象工厂模式
{
    class SQLserverUserTable : IUserTable
    {
        public void GetUser(int id)
        {
            Console.WriteLine("根据id值，在SQL中获取数据");
        }

        public void Insert(User user)
        {
            Console.WriteLine("在SQL中插入,user一行数据");
        }
    }
}
