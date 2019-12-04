using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_单例模式
{
    class CustomUIForm2
    {
        private static CustomUIForm2 instance;

        public static CustomUIForm2 Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new CustomUIForm2();
                }
                return instance;
            }
        }

        private CustomUIForm2()
        {

        }

        public void OpenUIForm(string path)
        {
            Console.WriteLine($"在路径 {path} 中打开UI");
        }
    }
}
