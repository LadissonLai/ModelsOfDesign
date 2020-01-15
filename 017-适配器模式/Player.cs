using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _017_适配器模式
{
    abstract class Player
    {
        abstract public string Name { get; set; }

        abstract public void Attack();

        abstract public void Defense();
    }
}
