using System;
using System.Collections.Generic;
using System.Text;

namespace _013_第十三章_建造者模式
{
    abstract class Builder
    {
        protected string CPU { get; set; }
        protected string GPU { get; set; }
        protected string Memory { get; set; }
        protected string SSD { get; set; }
        protected string Keyboard { get; set; }
        protected string Mouse { get; set; }

        public abstract void BuildCPU();
        public abstract void BuildGPU();
        public abstract void BuildMemory();
        public abstract void BuildSSD();
        public abstract void BuildKeyboard();
        public abstract void BuildMouse();
        public abstract Product GetProduct();
    }
}
