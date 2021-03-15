using System;

namespace _2._1._1._CUSTOM_STRING
{
    class MyString
    {
        static void Main(string[] args)
        {
            char[] myString1 = new char[] {'a', 'b', 'c', 'd', 'e'};
            char[] myString2 = new char[] {'a', 'b', 'c', 'd', 'f'};

            MyDLL.References.Equality(myString1, myString2);
        }
    }
}