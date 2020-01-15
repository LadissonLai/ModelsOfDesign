using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _017_适配器模式
{
    class Forward : Player
    {
        public override string Name { get; set; }

        public override void Attack()
        {
            Console.WriteLine($"前锋 {Name} 发起进攻");
        }

        public override void Defense()
        {
            Console.WriteLine($"前锋 {Name} 开始防守");
        }
    }
}
