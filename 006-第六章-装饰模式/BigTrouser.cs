﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006_第六章_装饰模式
{
    class BigTrouser : Decorator
    {

        public override void Show()
        {
            Console.Write("大衩裤");
            base.Show();
        }
    }
}
