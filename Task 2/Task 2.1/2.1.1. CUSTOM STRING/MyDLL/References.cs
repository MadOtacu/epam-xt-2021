using System;

namespace MyDLL
{
    public class References
    {
        public static bool Equality(char[] str1, char[] str2)
        {
            if (str1.Length != str2.Length)
            {
                return false;
            }
            for (int o = 0; o < str1.Length; o++)
            {
                if (str1[o] != str2[o])
                {
                    return false;
                }
            }
            return true;
        }

        public static char[] Concatination(char[] str1, char[] str2)
        {
            char[] finalString = new char[str1.Length + str2.Length];
            for (int o = 0; o < str1.Length; o++)
            {
                finalString[o] += str1[o];
            }
            for (int p = 0; p < str2.Length; p++)
            {
                finalString[p + str1.Length] += str2[p];
            }
            return finalString;
        }

        public static bool Search(char[] searchStr, char key)
        {
            foreach (char sym in searchStr)
            {
                if (sym == key)
                {
                    return true;
                }
            }
            return false;
        }

        public static void Print(char[] printableString)
        {
            foreach (char key in printableString)
            {
                Console.Write(key);
            }
        }

        public static char[] ToArray(char[] returningString)
        {
            return returningString;
        }

        public static char Indexer (char[] searchableString, int index)
        {
            return searchableString[index];
        }
    }
}
