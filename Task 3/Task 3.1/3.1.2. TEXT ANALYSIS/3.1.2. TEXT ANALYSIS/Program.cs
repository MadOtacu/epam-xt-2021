using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._1._2._TEXT_ANALYSIS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введи текст для проверки: ");

            string input = Console.ReadLine().ToUpper();

            char[] charSeparators = new char[] { ' ', ',', '.', '?', '!', '-', '"' };

            string[] words = input.Split(charSeparators, StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> myDictionary = new();

            myDictionary.FirstOrDefault(word => word.Key == words[0]);

            for (int o = 0; o < words.Length; o++)
            {
                if (myDictionary.ContainsKey(words[o]))
                {
                    myDictionary[words[o]]++;
                }
                else
                {
                    myDictionary.Add(words[o], 1);
                }
            }
            foreach (var item in myDictionary)
            {
                Console.WriteLine($"Слово {item.Key} встречается {item.Value} раз.");
            }

            if (myDictionary.Where(word => word.Value > 3).Count() < myDictionary.Count() * 0.2)
            {
                Console.WriteLine("У тебя прекрасный текст! Так держать!");
            }
            else
            {
                Console.WriteLine("Слишком много повторений! Попробуй разнообразить текст!");
            }
        }
    }
}
