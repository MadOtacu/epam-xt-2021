using System;

namespace _1._1._2._TRIANGLE
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите длину строки:");
            if (Int32.TryParse(Console.ReadLine(), out int length))
            {
                for (int i = 0; i < length; i++)
                {
                    for (int j = 0; j <= i; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine("");
                }
            }
            else { Console.WriteLine("Введите число!"); }
        }
    }
}
