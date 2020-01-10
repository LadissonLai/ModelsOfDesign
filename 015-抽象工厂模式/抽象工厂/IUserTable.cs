using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _015_抽象工厂模式
{
    interface IUserTable
    {
        /// <summary>
        /// 插入数据
        /// </summary>
        /// <param name="user"></param>
        void Insert(User user);
        /// <summary>
        /// 获取数据
        /// </summary>
        /// <param name="id"></param>
        void GetUser(int id);
    }
}
