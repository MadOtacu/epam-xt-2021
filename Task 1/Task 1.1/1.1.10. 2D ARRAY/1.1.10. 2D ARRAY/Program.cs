using System;

namespace _1._1._10._2D_ARRAY
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[10, 10];
            Random rand = new Random();
            int sum = 0;
            for (int k = 0; k < 5; k++)
            {
                for (int l = 0; l < 10; l++)
                {
                    arr[k, l] = rand.Next(100);
                }
            }
            for (int o = 0; o < 10; o++)
            {
                for (int p = 0; p < 10; p++)
                {
                    if ((o + p + 2) % 2 == 0)
                    {
                        sum += arr[o,p];
                    }
                }
            }
            Console.WriteLine(sum);
        }
    }
}
