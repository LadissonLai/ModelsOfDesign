using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _018_第十八章_备忘录模式
{
    class Program
    {
        static void Main(string[] args)
        {
            GameRole diaochan = new GameRole(); //创建貂蝉角色
            diaochan.InitState();
            diaochan.ShowState();

            MemoTaker memoTaker = diaochan.CreateMemoTaker();//创建备忘录的管理员

            diaochan.FightBoss();

            Console.WriteLine("死亡后，恢复数据!");
            diaochan.RecoveryMemo(memoTaker.Memo);//从管理员那里取得备忘录，然后恢复数据

            diaochan.ShowState();

            Console.ReadKey();
        }
    }
}
