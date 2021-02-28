using System;

namespace _1._1._3._ANOTHER_TRIANGLE
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество строк:");
            if (Int32.TryParse(Console.ReadLine(), out int height))
            {
                for (int i = 0; i < height; i++)
                {
                    for (int j = i; j < height - 1; j++)
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
            else { Console.WriteLine("Введите число!"); }
        }
    }
}
