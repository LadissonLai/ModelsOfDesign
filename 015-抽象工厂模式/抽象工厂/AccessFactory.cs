using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _015_抽象工厂模式
{
    class AccessFactory : IFactory
    {
        public IDepartment CreateDeprtTable()
        {
            return new AccessDeprtTable();
        }

        public IUserTable CreateUserTable()
        {
            return new AccessUserTable();
        }

    }
}
