using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _104_protected关键字测试
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1、protected关键字，子类可以调用父类中protected方法，并且是父亲的父亲的父亲...都可以
            // 2、实例化的类，不能调用protected方法
            GrandSon gson = new GrandSon();
            gson.GrandFunc(); 
            
        }
    }
}
