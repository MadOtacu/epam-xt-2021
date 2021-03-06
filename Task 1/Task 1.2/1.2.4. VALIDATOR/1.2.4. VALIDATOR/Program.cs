using System;
using System.Text;

namespace _1._2._4._VALIDATOR
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder sb = new StringBuilder();
            bool checkedSymbols = true;
            for (int o = 0; o < input.Length; o++)
            {
                if (checkedSymbols && Char.IsLetter(input[o]))
                {
                    sb.Append(Char.ToUpper(input[o]));
                    checkedSymbols = false;
                }
                else
                {
                    sb.Append(input[o]);
                }
                if (input[o] == '.' || input[o] == '?' || input[o] == '!')
                {
                    checkedSymbols = true;
                }
            }
            Console.WriteLine(sb);
        }
    }
}
