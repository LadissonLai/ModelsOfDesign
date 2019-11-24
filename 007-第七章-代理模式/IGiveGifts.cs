using System;
using System.Collections.Generic;
using System.Text;

namespace _007_第七章_代理模式
{
    /// <summary>
    /// 需要代理的事情就定义成接口或者抽象类
    /// </summary>
    interface IGiveGifts
    {
        void GiveDoll();

        void GiveFlower();

        void GiveChocolate();
    }
}
