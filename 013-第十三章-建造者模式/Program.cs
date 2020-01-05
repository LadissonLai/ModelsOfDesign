using System;

namespace _013_第十三章_建造者模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            /*本章节的目的是要组装一台电脑，我们需要的零部件有
             * cpu,gpu,内存，硬盘，显示器，键鼠，
             */
            LenovoPC PC = new LenovoPC("英特尔i7 9700K", "RTX2080Ti", "三星", "三星", "双飞燕", "罗技");
            Director director = new Director(PC);
            Product myPC = director.Construct();
            myPC.Show();

            Console.ReadKey();
        }
    }
}
