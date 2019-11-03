using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _005_第二章_策略模式
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double total = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            //cbxType.Items.AddRange(new object[] { "正常收费", "打八折", "打七折", "打五折" });
            cbxType.Items.AddRange(new object[] { "正常收费", "打八折", "满400减50", "打五折" });
            cbxType.SelectedIndex = 0;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            //2.1商场收银软件
            //double price = Convert.ToDouble(textBox1.Text);
            //double num = Convert.ToDouble(textBox2.Text);
            //double totalPrices = price * num;
            //total += totalPrices;
            //string item = "单价：" + price + " 数量：" + num + " 价格：" + totalPrices;
            //listBox1.Items.Add(item);
            //textBox3.Text = total.ToString();


            //2.2增加打折
            //double price = Convert.ToDouble(textBox1.Text);
            //double num = Convert.ToDouble(textBox2.Text);
            //double totalPrices = price * num;
            //switch (cbxType.SelectedIndex)
            //{
            //    case 0:
            //        break;
            //    case 1:
            //        totalPrices *= 0.8;
            //        break;
            //    case 2:
            //        totalPrices *= 0.7;
            //        break;
            //    case 3:
            //        totalPrices *= 0.5;
            //        break;
            //}
            //total += totalPrices;
            //string item = "单价：" + price + ", 数量：" + num + ", " + cbxType.SelectedItem.ToString() + ", 价格：" + totalPrices;
            //listBox1.Items.Add(item);
            //textBox3.Text = total.ToString();

            //2.3简单工厂实现
            //double price = Convert.ToDouble(textBox1.Text);
            //double num = Convert.ToDouble(textBox2.Text);
            //double totalPrices = price * num;
            //CashSuper cashSuper = CashFactory.CreateCashAccept(cbxType.SelectedItem.ToString());
            //totalPrices = cashSuper.AcceptCash(totalPrices);
            //total += totalPrices;
            //string item = "单价：" + price + ", 数量：" + num + ", " + cbxType.SelectedItem.ToString() + ", 价格：" + totalPrices;
            //listBox1.Items.Add(item);
            //textBox3.Text = total.ToString();

            //2.4策略模式和简单工厂 --目的在于让客户端的代码看起来简单且容易理解
            double price = Convert.ToDouble(textBox1.Text);
            double num = Convert.ToDouble(textBox2.Text);
            double totalPrices = price * num;

            CashContext cashContext = new CashContext(cbxType.SelectedItem.ToString());
            totalPrices = cashContext.GetResult(totalPrices);

            total += totalPrices;
            string item = "单价：" + price + ", 数量：" + num + ", " + cbxType.SelectedItem.ToString() + ", 价格：" + totalPrices;
            listBox1.Items.Add(item);
            textBox3.Text = total.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0.00";
            textBox2.Text = "0";
            textBox3.Text = "0.00";
            total = 0;
            listBox1.Items.Clear();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
