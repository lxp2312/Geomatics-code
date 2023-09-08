//极坐标转化为笛卡尔坐标
//引用相关库
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//命名空间
namespace ConsoleApp3
{
    //类
    class Program
    {
        //主函数
        static void Main(string[] args)
        {
            //输出提示信息
            Console.WriteLine("2110604109雷学鹏的项目");
            //定义变量
            double r, theta, x, y;
            //输入极坐标
            Console.WriteLine("请输入极坐标的半径r和角度theta");
            //读取输入的半径r和角度theta
            r = double.Parse(Console.ReadLine());
            theta = double.Parse(Console.ReadLine());
            theta = (int)theta + ((theta - (int)theta) * 100 - (theta - (int)theta) % 0.01 * 100) / 60 + (theta - (int)theta) * 10000 % 100 / 3600;
            //转化为角度
            theta = theta * Math.PI / 180;
            //计算x和ys
            x = r * Math.Cos(theta);
            y = r * Math.Sin(theta);
            //输出x和y
            Console.WriteLine("x={0},y={1}", x, y);
            //等待用户输入
            Console.ReadKey();
        }
    }
}

