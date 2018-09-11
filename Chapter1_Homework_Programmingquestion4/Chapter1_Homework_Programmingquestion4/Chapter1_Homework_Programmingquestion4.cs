using System;

namespace Chapter1_Homework_Programmingquestion4
{
    public class Chapter1_Homework_Programmingquestion4
    {
        public static void Main(string[] args)
        {
            //定义变量
            string s1 = "";
            string s2 = "";
            int n1, n2, product;
            //提示输入数字，接受并将字符（串）转化为整型数字
            Console.Write("Please input a number:");
            s1 = Console.ReadLine();
            n1 = Int32.Parse(s1);
            Console.Write("Please input another number:");
            s2 = Console.ReadLine();
            n2 = Int32.Parse(s2);
            //计算乘积并且输出
            product = n1 * n2;
            Console.Write($"The product of two number is {product}");
        }
    }
}
