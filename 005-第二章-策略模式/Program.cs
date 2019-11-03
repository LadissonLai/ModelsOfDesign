using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _005_第二章_策略模式
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            //ApplicationException
            Application.Run(new Form1());

        }
    }
}
