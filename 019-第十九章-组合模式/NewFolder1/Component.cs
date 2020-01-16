using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _019_第十九章_组合模式
{
    abstract class Component
    {
        public string name;
        public Component(string name)
        {
            this.name = name;
        }
        /// <summary>
        /// 添加树枝节点
        /// </summary>
        /// <param name="c"></param>
        public abstract void Add(Component c);
        /// <summary>
        /// 移除树枝节点
        /// </summary>
        /// <param name="c"></param>
        public abstract void Remove(Component c);
        /// <summary>
        /// 显示树枝的形状
        /// </summary>
        /// <param name="depth"></param>
        public abstract void Display(int depth);

    }
}
