using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _102_子类转父类调子类方法
{
    class Son : Father
    {
        public override void TestFunc()
        {
            base.TestFunc();
            Console.WriteLine("这里是子类重写父类的方法");
        }

        public void SonFunc()
        {
            Console.WriteLine("这是儿子自己的方法");
        }
    }
}
