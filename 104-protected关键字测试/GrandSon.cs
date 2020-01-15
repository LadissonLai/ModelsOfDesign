using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _104_protected关键字测试
{
    class GrandSon : Son
    {
        public void GrandFunc()
        {
            FatherFunc();
            SonFunc();
        }
    }
}
