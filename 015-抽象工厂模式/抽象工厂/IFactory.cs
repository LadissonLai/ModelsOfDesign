using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _015_抽象工厂模式
{
    interface IFactory
    {
        IUserTable CreateUserTable();
        IDepartment CreateDeprtTable();
    }
}
