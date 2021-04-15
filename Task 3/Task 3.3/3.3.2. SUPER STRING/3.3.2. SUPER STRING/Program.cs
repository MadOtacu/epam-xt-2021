using System;
using System.Linq;

namespace _3._3._2._SUPER_STRING
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }

    static class SuperString
    {
        public enum Languages
        {
            Russian,
            English,
            Number,
            Mixed
        }

        static Languages GetLanguage (this string checkableString)
        {
            char[] checkableStringArr = checkableString.ToCharArray();

            if (checkableStringArr.All(c => char.IsDigit(c)))
            {
                return Languages.Number;
            }
            else if (checkableStringArr.All(c => (c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z')))
            {
                return Languages.English;
            }
            else if (checkableStringArr.All(c => (c >= 'а' && c <= 'я') || (c >= 'А' && c <= 'Я')))
            {
                return Languages.Russian;
            }
            else
            {
                return Languages.Mixed;
            }
        }
    }
}
