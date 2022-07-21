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
            PrintList(list);
            RemoveDuplicateNumbers(list);

            Console.WriteLine("\nОтформатированный список: ");
            PrintList(list);
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
            BubbleSort(list);

            for (int i = 1; i < list.Count; i++)
            {
                if (list[i] == list[i - 1])
                {
                    list.RemoveAt(i);
                }
            }
        }

        static void BubbleSort(List<int> list)
        {
            int temp;

            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 0; j < list.Count - 1; j++)
                {
                    if (list[j] > list[j + 1])
                    {
                        temp = list[j + 1];
                        list[j + 1] = list[j];
                        list[j] = temp;
                    }
                }
            }
        }

        static void PrintList(List<int> list)
        {
            foreach (int number in list)
            {
                Console.Write($"{number} ");
            }
        }
    }
}
