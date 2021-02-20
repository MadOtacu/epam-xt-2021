using System;

namespace _1._1._1_RECTANGLE
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 0;
            while (a <= 0 || b <= 0)
            {
                Console.Write("Введите значение a:");
                a = Int32.Parse(Console.ReadLine());
                Console.Write("Введите значение b:");
                b = Int32.Parse(Console.ReadLine());
                if (a <= 0 || b <= 0)
                {
                    Console.WriteLine("Введите значения больше нуля!");
                }
            }
            Console.WriteLine($"Площадь прямоугольника равна {a * b}");
        }
    }
}
