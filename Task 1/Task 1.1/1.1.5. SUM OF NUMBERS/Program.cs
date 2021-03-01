using System;

namespace _1._1._5._SUM_OF_NUMBERS
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = 0;
            int sum = 0;
            while (length < 1000)
            {
                if (length % 3 == 0 || length % 5 == 0)
                {
                    sum += length;
                }
                length++;
            }
            Console.WriteLine($"Сумма всех чисел кратных 3 и 5 равна {sum}");
        }
    }
}
