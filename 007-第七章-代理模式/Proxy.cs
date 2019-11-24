using System;
using System.Collections.Generic;
using System.Text;

namespace _007_第七章_代理模式
{
    class Proxy : IGiveGifts
    {
        private readonly Pursuiter pursuiter;
        public Proxy(SchoolGirl schoolGirl)
        {
            pursuiter = new Pursuiter(schoolGirl);
        }

        public void GiveChocolate()
        {
            pursuiter.GiveChocolate();
        }

        public void GiveDoll()
        {
            pursuiter.GiveDoll();
        }

        public void GiveFlower()
        {
            pursuiter.GiveFlower();
        }
    }
}
