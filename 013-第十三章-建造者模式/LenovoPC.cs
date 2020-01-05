using System;
using System.Collections.Generic;
using System.Text;

namespace _013_第十三章_建造者模式
{
    class LenovoPC : Builder
    {
        private Product product = new Product();
        public override void BuildCPU()
        {
            product.Add(CPU);
        }

        public override void BuildGPU()
        {
            product.Add(GPU);
        }

        public override void BuildKeyboard()
        {
            product.Add(Keyboard);
        }

        public override void BuildMemory()
        {
            product.Add(Memory);
        }

        public override void BuildMouse()
        {
            product.Add(Mouse);
        }

        public override void BuildSSD()
        {
            product.Add(SSD);
        }

        public override Product GetProduct()
        {
            return product;
        }

        public LenovoPC(string cpu,string gpu,string memory,string ssd,string keyboard,string mouse)
        {
            this.CPU = cpu;
            this.GPU = gpu;
            this.Memory = memory;
            this.SSD = ssd;
            this.Keyboard = keyboard;
            this.Mouse = mouse;
        }

    }
}
