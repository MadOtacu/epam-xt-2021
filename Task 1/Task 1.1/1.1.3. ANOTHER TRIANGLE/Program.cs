using System;

namespace _1._1._3._ANOTHER_TRIANGLE
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.Write("Введите количество строк:");
            a = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < a; i++)
            {
                for (int j = i; j < a-1; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < i; k++)
                {
                    Console.Write("**");
                }
                Console.WriteLine("*");
            }
        }
    }
}
