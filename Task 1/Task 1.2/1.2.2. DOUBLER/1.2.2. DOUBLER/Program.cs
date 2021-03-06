using System;
using System.Text;

namespace _1._2._2._DOUBLER
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string doublestr = Console.ReadLine();
            StringBuilder stringBuilder = new StringBuilder();
            foreach (char checkedSymbol in input)
            {
                if (doublestr.Contains(checkedSymbol))
                {
                    stringBuilder.Append(checkedSymbol);
                }
                stringBuilder.Append(checkedSymbol);
            }
            Console.WriteLine(stringBuilder);
        }
    }
}
