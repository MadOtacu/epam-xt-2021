using System;

namespace _1._1._2._TRIANGLE
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.Write("Введите длину строки:");
            a = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
        }
    }
}
