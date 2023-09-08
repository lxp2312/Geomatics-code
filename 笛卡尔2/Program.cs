//极坐标转化为笛卡尔坐标，角度输入格式为度分秒，如45.0234代表45度2分34秒
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
            //定义变量
            double r, theta, x, y;
            //输入极坐标
            Console.WriteLine("请输入极坐标的半径r和角度theta");
            //读取输入的半径r和角度theta
            r = double.Parse(Console.ReadLine());
            theta = double.Parse(Console.ReadLine());
            //计算x和y
            x = r * Math.Cos(theta);
            y = r * Math.Sin(theta);
            //输出x和y
            Console.WriteLine("x={0},y={1}", x, y);
            //等待用户输入
            Console.ReadKey();
        }
    }
}