using System;

namespace _1._1._4._X_MAS_TREE
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество треугольников:");
            if (Int32.TryParse(Console.ReadLine(), out int height))
            {
                for (int i = 0; i < height; i++)
                {
                    for (int o = 0; o <= i; o++)
                    {
                        for (int j = o; j <= height; j++)
                        {
                            Console.Write(" ");
                        }
                        for (int k = 0; k < o; k++)
                        {
                            Console.Write("**");
                        }
                        Console.WriteLine("*");
                    }
                }
            }
            else { Console.WriteLine("Введите число!"); }
        }
    }
}
