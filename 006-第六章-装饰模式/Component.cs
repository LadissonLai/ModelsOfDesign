using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006_第六章_装饰模式
{
    /// <summary>
    /// 换装对象的基本类型
    /// </summary>
    abstract class Component
    {
        /// <summary>
        /// 换装的方法
        /// </summary>
        public abstract void Show();
    }
}
