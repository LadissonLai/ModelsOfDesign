using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _016_第十六章_状态模式
{
    class Program  
    {
        static void Main(string[] args)
        {
            Work myWork = new Work
            {
                Hour = 9f,
                TaskFinish = false,
            };
            myWork.WriteProgram();
            myWork.Hour = 12f;
            myWork.WriteProgram();
            myWork.Hour = 14f;
            myWork.WriteProgram();
            myWork.Hour = 18f;
            myWork.WriteProgram();

            myWork.TaskFinish = false;
            myWork.Hour = 21f;
            myWork.WriteProgram();
            Console.ReadKey();
        }
    }
}
