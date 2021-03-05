using System;

namespace _1._1._8._NO_POSITIVE
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,,] arr = new int[10, 10, 5];
            Random rand = new Random();
            for (int o = 0; o < 10; o++)
            {
                for (int p = 0; p < 10; p++)
                {
                    for (int q = 0; q < 5; q++)
                    {
                        arr[o, p, q] = rand.Next(500);
                    }
                }
            }
            for (int o = 0; o < 10; o++)
            {
                for (int p = 0; p < 10; p++)
                {
                    for (int q = 0; q < 5; q++)
                    {
                        if (arr[o, p, q] > 0)
                        {
                            arr[o, p, q] = 0;
                            Console.WriteLine(arr[o, p, q]);
                        }
                    }
                }
            }
        }
    }
}
