using System;

namespace _007_第七章_代理模式
{
    class Program
    {
        static void Main(string[] args)
        {
            //卓贾易追娇娇，让戴利送礼物，成全了娇娇和戴利，为别人做嫁衣，代理模式
            SchoolGirl jiaojiao = new SchoolGirl()
            {
                Name = "李娇娇"
            };

            Proxy daili = new Proxy(jiaojiao);
            daili.GiveChocolate();
            daili.GiveDoll();
            daili.GiveFlower();

            Console.ReadKey();
        }
    }
}
