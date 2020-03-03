using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _106_类型转换测试
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal seal = new Seal() { AnimalType = "海豹" };
            Bird sparrow = new Bird() { AnimalType = "麻雀" };
            Bird sparrow2 = new FlappyBird() { AnimalType = "飞扬的小鸟2" };
            FlappyBird fbird = new FlappyBird() { AnimalType = "飞扬的小鸟" };
            if(fbird is Bird) //成功
            {
                Console.WriteLine("fbird is Bird");
            }
            if(sparrow is FlappyBird) //不成功，说明子类的实例化才是父类，而父类实例化不是子类
            {
                Console.WriteLine("sparrow is FlappyBird");
            }

            #region 父类转子类
            FlappyBird newBird = sparrow as FlappyBird; //不成功，父类实例化是不能转成子类，如果可以那就是多态，
            if(newBird != null)
            {
                newBird.FlappyFunc();
            }
            else
            {
                Console.WriteLine("父类转子类失败。");
            }

            FlappyBird newBird3 = sparrow2 as FlappyBird;
            if (newBird3 != null)
            {
                Console.WriteLine("多态，父类转子类成功。父类声明，子类初始化的对象，可以转换为父类");
            }
            #endregion

            #region 子类转父类一定成功
            Bird newBird1 = fbird as Bird;
            if (newBird1 != null)
            {
                Console.WriteLine("子类实例化对象转换成了父类对象。");
            }
            #endregion

            ///1-子类转父类一定可以成功；
            ///2-父类转子类不一定成功，除非多态
            Console.ReadKey();
        }
    }
}
