using System;

namespace _014_第十四章_观察者模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            #region 测试GF的观察者模式
            Student taylor = new Student("泰勒");
            Student monitor = new Student("班长");
            Ctrl.Instance.Subscribe(TeacherComeEventArgs.EventId, TeacherComeHandler); //这里的EventId是唯一确定了吗?
            
            taylor.PlayGames();
            Console.WriteLine("语文老师进来了!");
            TeacherComeEventArgs e = Ctrl.Instance.Acquire<TeacherComeEventArgs>();
            Ctrl.Instance.Fire(monitor, e);
            #endregion

            Console.ReadKey();
            //回调函数
            void TeacherComeHandler(object sender, EventArgs e)
            {
                TeacherComeEventArgs args = e as TeacherComeEventArgs;
                if (args != null)
                {
                    Console.WriteLine("老师我错了，不要没收我的手机，我下次不敢了！我是{0}", taylor.Name);
                }
            }
        }

        
    }
}
