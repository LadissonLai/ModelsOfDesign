using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _017_适配器模式
{
    class ForeignCenter
    {
        public string Name { get; set; }

        public void 进攻()
        {
            Console.WriteLine($"外籍中锋 {Name} 发起进攻");
        }

        public void 防守()
        {
            Console.WriteLine($"外籍中锋 {Name} 开始防守");
        }
    }
}
