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

        double totalPrice = 0;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Hollow World!");
            double price = Convert.ToDouble(textBox1.Text);
            double num = Convert.ToDouble(textBox2.Text);
            double currPrice = price * num;

            totalPrice += currPrice;
            string item = "单价：" + price + " 数量：" + num + " 价格：" + currPrice;
            listBox1.Items.Add(item);

            textBox3.Text = totalPrice.ToString();
            //textBox1.Text
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0.00";
            textBox2.Text = "0";
            textBox3.Text = "0.00";
            totalPrice = 0;
            listBox1.Items.Clear();
                
        }
    }
}
