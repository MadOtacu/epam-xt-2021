using System;

namespace _1._1._7._ARRAY_PROCESSING
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[15];
            Random rand = new Random();
            for (int o = 0; o < arr.Length; o++)
            {
                arr[o] = rand.Next();
            }
            for (int p = 0; p < arr.Length; p++)
            {
                for (int q = p + 1; q < arr.Length; q++)
                {
                    if (arr [p] > arr [q])
                    {
                        int temp = arr[p];
                        arr[p] = arr[q];
                        arr[q] = temp;
                    }
                }
                Console.WriteLine(arr[p]);
            }
        }
    }
}
