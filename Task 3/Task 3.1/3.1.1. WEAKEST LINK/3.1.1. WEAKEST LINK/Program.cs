using System;
using System.Collections.Generic;

namespace _3._1._1._WEAKEST_LINK
{
    class Program
    {
        static void Main(string[] args)
        {
            List<object> members = new List<object>();
            while (true)
            {
                Console.Write("Введите N: ");
                bool correctN = int.TryParse(Console.ReadLine(), out int n);
                if (!correctN)
                {
                    Console.WriteLine("Введите число!");
                    continue;
                }
                for (int o = 0; o < n; o++)
                {
                    object member = new();
                    members.Add(member);
                }
                Console.WriteLine("Сгенерирован круг людей. Начинаем вычеркивать каждого второго.");
                CrossingOut(members);
            }
        }

        public static void CrossingOut(List<object> members)
        {
            int roundCounter = 1;

            for (int i = 1; i < members.Count; i++)
            {
                members.RemoveAt(i);

                Console.WriteLine($"Раунд {roundCounter}. Вычеркнут человек. Людей осталось: {members.Count}");

                roundCounter++;

                if (members.Count % 2 == 0)
                {
                    i = 0;
                }
                if (members.Count % 2 == 1)
                {
                    i = -1;
                }
                if (members.Count == 1)
                {
                    Console.WriteLine("Игра окончена. Невозможно вычеркнуть больше людей.");
                    Environment.Exit(0);
                }
            }
        }
    }
}
