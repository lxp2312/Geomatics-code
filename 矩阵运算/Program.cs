//矩阵乘法运算
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
            //定义矩阵A，用户可以自定义矩阵的行数和列数
            Console.WriteLine("请输入矩阵A的行数和列数");
            int rowA = int.Parse(Console.ReadLine());
            int colA = int.Parse(Console.ReadLine());
            int[,] A = new int[rowA, colA];

            //定义矩阵B，用户可以自定义矩阵的行数和列数
            Console.WriteLine("请输入矩阵B的行数和列数");
            int rowB = int.Parse(Console.ReadLine());
            int colB = int.Parse(Console.ReadLine());
            int[,] B = new int[rowB, colB];
            //定义矩阵C
            int[,] C = new int[rowA, colB];
            //输入矩阵A,以字符串的形式输入，用空格分隔
            Console.WriteLine("请输入矩阵A");
            string strA = Console.ReadLine();
            string[] strArrayA = strA.Split(' ');
            int countA = 0;
            for (int i = 0; i < rowA; i++)
            {
                for (int j = 0; j < colA; j++)
                {
                    A[i, j] = int.Parse(strArrayA[countA]);
                    countA++;
                }
            }
            //输入矩阵B,以字符串的形式输入，用空格分隔
            Console.WriteLine("请输入矩阵B");
            string strB = Console.ReadLine();
            string[] strArrayB = strB.Split(' ');
            int countB = 0;
            for (int i = 0; i < rowB; i++)
            {
                for (int j = 0; j < colB; j++)
                {
                    B[i, j] = int.Parse(strArrayB[countB]);
                    countB++;
                }
            }
            //矩阵乘法运算
            for (int i = 0; i < rowA; i++)
            {
                for (int j = 0; j < colB; j++)
                {
                    for (int k = 0; k < rowB; k++)
                    {
                        C[i, j] += A[i, k] * B[k, j];
                    }
                }
            }
            //输出矩阵C
            Console.WriteLine("矩阵C为");
            for (int i = 0; i < rowA; i++)
            {
                for (int j = 0; j < colB; j++)
                {
                    Console.Write("{0} ", C[i, j]);
                }
                Console.WriteLine();
            }
            //等待用户输入
            Console.ReadKey();
        }
    }
}
