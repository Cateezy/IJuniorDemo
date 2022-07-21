using System;
using System.Collections.Generic;

namespace IJuniorDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstArray = new int[] { 3, 4, 3, 7, 8};
            int[] secondArray = new int[] { 5, 7, 8, 1, 4 };
            List<int> list = new List<int>();

            ConvertArrayToList(firstArray, list);
            ConvertArrayToList(secondArray, list);

            Console.WriteLine("Исходный список: ");

            foreach (int number in list)
            {
                Console.Write($"{number} ");
            }

            RemoveDuplicateNumbers(list);
            Console.WriteLine("\nОтформатированный список: ");

            foreach (int number in list)
            {
                Console.Write($"{number} ");
            }
        }

        static void ConvertArrayToList(int[] array, List<int> list)
        {
            foreach (int number in array)
            {
                list.Add(number);
            }
        }

        static void RemoveDuplicateNumbers(List<int> list)
        {
            list.Sort();

            for (int i = 1; i < list.Count; i++)
            {
                if (list[i] == list[i - 1])
                {
                    list.RemoveAt(i);
                }
            }
        }
    }
}
