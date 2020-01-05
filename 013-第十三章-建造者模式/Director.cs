using System;
using System.Collections.Generic;
using System.Text;

namespace _013_第十三章_建造者模式
{
    class Director
    {
        private readonly Builder builder;
        public Director(Builder b)
        {
            builder = b;
        }

        /// <summary>
        /// 这里写了建造顺序
        /// </summary>
        public Product Construct()
        {
            builder.BuildCPU();
            builder.BuildGPU();
            builder.BuildMemory();
            builder.BuildSSD();
            builder.BuildKeyboard();
            builder.BuildMouse();
            return builder.GetProduct();
        }
    }
}
