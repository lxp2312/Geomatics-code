//读取txt文件内点位数据，格式为x,y。计算这些点位围成的面积
//引用相关库
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
//命名空间
namespace 计算面积
{
    //类
    class Program
    {
        //主函数
        static void Main(string[] args)
        {
            //定义变量
            string path = @"C:\Users\lxp\Desktop\test.txt";
            string[] lines = File.ReadAllLines(path);
            double[] x = new double[lines.Length]; 
            double[] y = new double[lines.Length];
            double area = 0;
            //循环读取txt文件内的数据
            for (int i = 0; i < lines.Length; i++)
            {
                string[] line = lines[i].Split(',');
                x[i] = Convert.ToDouble(line[0]);
                y[i] = Convert.ToDouble(line[1]);
            }
            //计算面积
            for (int i = 0; i < lines.Length - 1; i++)
            {
                area += x[i] * y[i + 1] - x[i + 1] * y[i];
            }
            area += x[lines.Length - 1] * y[0] - x[0] * y[lines.Length - 1];
            area = Math.Abs(area) / 2;
            //输出结果
            Console.WriteLine("面积为：" + area);
            Console.ReadKey();
        }
    }
}