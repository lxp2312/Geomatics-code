// 参心大地坐标系转参心空间直角坐标系
//引用相关库
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//命名空间
namespace 大地坐标系转空间直角坐标系
{
    class Program
    {
        //主函数
        static void Main(string[] args)
        {
            //定义变量
            double B, L, H, a, b, e1, e2, N, X, Y, Z;
            //输入参数
            Console.WriteLine("请输入大地纬度B：");
            B = double.Parse(Console.ReadLine());
            Console.WriteLine("请输入大地经度L：");
            L = double.Parse(Console.ReadLine());
            Console.WriteLine("请输入大地高H：");
            H = double.Parse(Console.ReadLine());
            //定义参数
            a = 6378137;
            b = 6356752.3142;
            e1 = Math.Sqrt((Math.Pow(a, 2) - Math.Pow(b, 2)) / Math.Pow(a, 2));
            e2 = Math.Sqrt((Math.Pow(a, 2) - Math.Pow(b, 2)) / Math.Pow(b, 2));
            //计算
            B = B * Math.PI / 180;
            L = L * Math.PI / 180;
            N = a / Math.Sqrt(1 - Math.Pow(e1, 2) * Math.Pow(Math.Sin(B), 2));
            X = (N + H) * Math.Cos(B) * Math.Cos(L);
            Y = (N + H) * Math.Cos(B) * Math.Sin(L);
            Z = (N * (1 - Math.Pow(e1, 2)) + H) * Math.Sin(B);
            //输出结果
            Console.WriteLine("X={0}", X);
            Console.WriteLine("Y={0}", Y);
            Console.WriteLine("Z={0}", Z);
            Console.ReadLine();
        }
    }
}