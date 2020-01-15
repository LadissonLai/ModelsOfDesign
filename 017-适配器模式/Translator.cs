using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _017_适配器模式
{
    class Translator : Player
    {
        public override string Name { get; set; }

        private ForeignCenter wjzf;

        public Translator(ForeignCenter center)
        {
            wjzf = center;
        }

        public override void Attack()
        {
            wjzf.进攻();
        }

        public override void Defense()
        {
            wjzf.防守();
        }
    }
}
