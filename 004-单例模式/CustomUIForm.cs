using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_单例模式
{
    class CustomUIForm
    {
        public static CustomUIForm Instance;
        //public static CustomUIForm Create()
        //{
        //    if(Instance == null)
        //    {
        //        Instance = new CustomUIForm();
        //    }
        //    return Instance;
        //}

        //私有构造方法
        private CustomUIForm()
        {

        }

        public void OpenUIForm(string path)
        {
            Console.WriteLine($"在路径{path}中打开UI");
        }


        
    }
}
