using System;
using System.Collections.Generic;

namespace _1._1._6._FONT_ADJUSTMENT
{
    class Program
    {
        static void Main(string[] args)
        {
            Int32.TryParse(Console.ReadLine(), out int temp);
            List<string> MyList = new List<string>();
            do
            {
                switch (temp)
                {
                    case 1:
                        if (MyList.Contains("Bold")) MyList.Remove("Bold");
                        else
                        {
                            MyList.Add("Bold");
                        }
                        Console.WriteLine(string.Join(", ", MyList));
                        break;
                    case 2:
                        if (MyList.Contains("Italic")) MyList.Remove("Italic");
                        else
                        {
                            MyList.Add("Italic");
                        }
                        Console.WriteLine(string.Join(", ", MyList));
                        break;
                    case 3:
                        if (MyList.Contains("Underline")) MyList.Remove("Underline");
                        else
                        {
                            MyList.Add("Underline");
                        }
                        Console.WriteLine(string.Join(", ", MyList));
                        break;
                    default:
                        Console.WriteLine("Введите значение от 1 до 3!");
                        break;
                }
            }
            while (int.TryParse(Console.ReadLine(), out temp));
        }
    }
}
