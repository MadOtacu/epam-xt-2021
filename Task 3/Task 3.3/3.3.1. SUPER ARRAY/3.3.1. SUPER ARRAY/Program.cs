using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._3._1._SUPER_ARRAY
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }

    public static class SuperArray
    {
        public static void DoSomething<T> (this T[] items, Action<T> action)
        {
            foreach (var item in items)
            {
                action(item);
            }
        }

        static int Sum (this int[] items)
        {
            int sum = 0;

            foreach (var item in items)
            {
                sum += item;
            }

            return sum;
        }

        static int Average (this int[] items)
        {
             int average = items.Sum() / items.Length;

            return average;
        }

        static T MostUseful<T> (this T[] items)
        {
            T most = (from i in items
                      group i by i into grp
                      orderby grp.Count() descending
                      select grp.Key).First();

            return most;
        }
    }
}
