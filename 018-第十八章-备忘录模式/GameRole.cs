using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _018_第十八章_备忘录模式
{
    class GameRole
    {
        public int Vitality { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
        
        public GameRole(int vit,int atk,int df)
        {
            Vitality = vit;
            Attack = atk;
            Defense = df;
        }
        public GameRole()
        {

        }

        /// <summary>
        /// 创建备忘录
        /// </summary>
        /// <returns></returns>
        public MemoTaker CreateMemoTaker()
        {
            Memo m = new Memo(Vitality, Attack, Defense);
            return new MemoTaker(m);
        }

        /// <summary>
        /// 恢复备忘录
        /// </summary>
        /// <param name="memo"></param>
        public void RecoveryMemo(Memo memo)
        {
            Vitality = memo.Vitality;
            Attack = memo.Attack;
            Defense = memo.Defense;
        }

        /// <summary>
        /// 打boss
        /// </summary>
        public void FightBoss()
        {
            Vitality = 0;
            Attack = 0;
            Defense = 0;
            Console.WriteLine("正在打boss!!!冲冲冲!!!");
        }

        /// <summary>
        /// 展示角色状态信息
        /// </summary>
        public void ShowState()
        {
            Console.WriteLine($"Vitality:{Vitality}  Attack:{Attack}  Defense:{Defense}");
        }

        /// <summary>
        /// 初始化角色状态
        /// </summary>
        public void InitState()
        {
            Vitality = 100;
            Attack = 100;
            Defense = 100;
        }
    }
}
