using System;
using System.Collections.Generic;
using System.Text;

namespace _014_第十四章_观察者模式
{
    class Student
    {
        public string Name { get; set; }

        public void PlayGames()
        {
            Console.WriteLine("我正在玩游戏，哈哈哈！");
        }

        public Student(string name)
        {
            Name = name;
        }
    }
}
