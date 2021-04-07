using System;
using System.Collections.Generic;

namespace _3._2._1._DYNAMIC_ARRAY
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }

    class DynamicArray<T>
    {
        public DynamicArray () 
        {
            T[] dynamicArray = new T[8];
        }

        public DynamicArray (int capacity)
        {
            T[] dynamicArray = new T[capacity];
        }
    }
}
