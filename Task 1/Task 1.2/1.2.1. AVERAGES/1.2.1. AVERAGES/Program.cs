using System;

namespace _1._2._1._AVERAGES
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] except = new char[] { ' ', '!', '?', ',', '.'};
            int sum = 0;
            string str = Console.ReadLine();
            string[] words = str.Split(except, StringSplitOptions.RemoveEmptyEntries);
            for (int o = 0; o < words.Length; o++)
            {
                sum += words[o].Length;
            }
            //Вывод с округлением :D
            Console.WriteLine(sum / words.Length);
        }
    }
}
