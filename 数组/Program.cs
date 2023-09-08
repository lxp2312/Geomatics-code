//创建一个关于学生信息的结构数组，每个结构包含学生姓名(name)、学号(id)、成绩(scores)
//引用相关库
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//命名空间
namespace ConsoleApp3
{
    //结构
    struct Student
    {
        //定义变量
        public string name;
        public int id;
        public int[] scores;
    }
    //类
    class Program
    {
        //主函数
        static void Main(string[] args)
        {
            //定义结构数组
            Student[] students = new Student[3];
            //输入学生信息
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("请输入第{0}个学生的姓名、学号、成绩", i + 1);
                students[i].name = Console.ReadLine();
                students[i].id = int.Parse(Console.ReadLine());
                students[i].scores = new int[3];
                for (int j = 0; j < 3; j++)
                {
                    students[i].scores[j] = int.Parse(Console.ReadLine());
                }
            }
            //输出学生信息
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("第{0}个学生的姓名、学号、成绩", i + 1);
                Console.WriteLine(students[i].name);
                Console.WriteLine(students[i].id);
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine(students[i].scores[j]);
                }
            }
            //等待用户输入
            Console.ReadKey();
        }
    }
}