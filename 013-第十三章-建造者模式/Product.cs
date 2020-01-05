using System;
using System.Collections.Generic;
using System.Text;

namespace _013_第十三章_建造者模式
{
    class Product
    {
        public List<string> parts;

        public Product()
        {
            parts = new List<string>();
        }

        public void Add(string str)
        {
            parts.Add(str);
        }

        public void Show()
        {
            if (parts.Count > 0)
            {
                Console.WriteLine("这台电脑的配置是：" +
                    "{0}的CPU,{1}牌子的GPU，{2}牌子的内存，{3}牌子的SSD，{4}牌子的键盘，{5}牌子的鼠标",
                    parts[0], parts[1], parts[2], parts[3], parts[4], parts[5]);
            }
        }
    }
}
