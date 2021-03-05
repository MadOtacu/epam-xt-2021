using System;

namespace _1._1._9._NON_NEGATIVE_SUM
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] {1, -2, 3, -4, 5, -6, 7, -8, 9, -10, 11, -12, 13, -14, 15};
            int sum = 0;
            for (int o = 0; o < arr.Length; o++)
            {
                if (arr[o] < 0)
                {
                    sum += arr[o];
                }
            }
            Console.WriteLine(sum);
        }
    }
}
