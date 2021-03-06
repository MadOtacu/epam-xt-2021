using System;

namespace _1._2._3._LOWERCASE
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] splitted = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            int sum = 0;
            for (int o = 0; o < splitted.Length; o++)
            {
                if (Char.IsLower(splitted[o][0]))
                {
                    sum++;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
