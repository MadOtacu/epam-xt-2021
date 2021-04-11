using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _3._2._1._DYNAMIC_ARRAY
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }

    class DynamicArray<T> : IEnumerable, IEnumerable<T>
    {
        T[] dynamicArray;

        public int Length { get; private set; }
        public DynamicArray () 
        {
            dynamicArray = new T[8];
        }

        public DynamicArray (int capacity)
        {
            dynamicArray = new T[capacity];
        }

        public DynamicArray (IEnumerable<T> listToArray)
        {
            dynamicArray = listToArray.ToArray();

            Length += (from item in dynamicArray select item).Count();
        }

        void CapacityMultipler (int length)
        {
            int finalCapacity = dynamicArray.Length;

            while (finalCapacity < length)
            {
                finalCapacity *= 2;
            }

            T[] tempArr = new T[finalCapacity];

            for (int o = 0; o < Length; o++)
            {
                tempArr[o] = dynamicArray[o];
            }

            dynamicArray = tempArr;
        }

        void Add (T appendableObject)
        {
            if (Length == dynamicArray.Length)
            {
                CapacityMultipler(++Length);
            }

            dynamicArray.Append<T>(appendableObject);
        }

        void AddRange (IEnumerable<T> appendableList)
        {
            foreach (var item in appendableList)
            {
                if (Length == dynamicArray.Length)
                {
                    CapacityMultipler(++Length);
                }

                dynamicArray.Append<T>(item);
            }
        }

        bool Remove (int removableObjectIndex)
        {
            for (int i = 0; i < dynamicArray.Length; i++)
            {
                if (i == removableObjectIndex)
                {
                    if (removableObjectIndex < 0 || removableObjectIndex >= Length)
                        throw new ArgumentOutOfRangeException();
                    Array.Copy(dynamicArray, i + 1, dynamicArray, i, Length - i);
                    Length--;
                    return true;
                }
            }
            return false;
        }

        bool Insert(int addableObjectIndex, T addableObject)
        {
            if (addableObjectIndex < 0 || addableObjectIndex >= Length) throw new ArgumentOutOfRangeException();
            if (Length == dynamicArray.Length)
            {
                CapacityMultipler(++Length);
            }
            for (int i = Length; i >= addableObjectIndex; i--)
            {
                dynamicArray[i + 1] = dynamicArray[i];
            }
            Length++;
            dynamicArray[addableObjectIndex] = addableObject;
            return true;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            for (int i = 0; i < Length; i++)
            {
                yield return dynamicArray[i];
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < Length; i++)
            {
                yield return dynamicArray[i];
            }
        }

        T Indexer (int index)
        {
            return dynamicArray[index];
        }
    }
}
