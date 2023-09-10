using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 窗口矩阵
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //读取文本框中的内容，用，分割，存入数组
            string[] str = textBox1.Text.Split(',');

            //将数组中的内容存入矩阵，矩阵大小根据输入决定
            int[,] a = new int[Convert.ToInt32(str[32]), Convert.ToInt32(str[33])];
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //读取文本框中的内容，用，分割，存入数组
            string[] str = textBox2.Text.Split(',');
            //将数组中的内容存入矩阵，矩阵大小根据输入决定
            int[,] b = new int[Convert.ToInt32(str[0]), Convert.ToInt32(str[1])];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //引用上述变量a,b
            string[] str = textBox1.Text.Split(',');
            int[,] a = new int[Convert.ToInt32(str[0]), Convert.ToInt32(str[1])];
            str = textBox2.Text.Split(',');
            int[,] b = new int[Convert.ToInt32(str[0]), Convert.ToInt32(str[1])];
            //用a,b矩阵相加，结果存入c矩阵
            int[,] c = new int[a.GetLength(0), a.GetLength(1)];
            //判断矩阵是否可以相加
            if (a.GetLength(0) == b.GetLength(0) && a.GetLength(1) == b.GetLength(1))
            {
                //相加
                for (int i = 0; i < a.GetLength(0); i++)
                {
                    for (int j = 0; j < a.GetLength(1); j++)
                    {
                        c[i, j] = a[i, j] + b[i, j];
                    }
                }
                //将结果输出到文本框
                textBox4.Text = "";
                for (int i = 0; i < c.GetLength(0); i++)
                {
                    for (int j = 0; j < c.GetLength(1); j++)
                    {
                        textBox4.Text += c[i, j] + " ";
                    }
                    textBox4.Text += "\r\n";
                }
            }
            else
            {
                MessageBox.Show("矩阵大小不一致，无法相加");
            }
        }
    }
}
