using System;

namespace IJuniorDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbersInArray = 30;
            int[] array = new int[numbersInArray];
            Random random = new Random();
            int minNumberForRandom = 0;
            int maxNumberForRandom = 10;
            Console.WriteLine("Изначальный массив: ");

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(minNumberForRandom, maxNumberForRandom);
                Console.Write($"{array[i]} ");
            }

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    int temp;

                    if (array[i] > array[j])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }

            Console.WriteLine("\nОтсортированный массив: ");

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
        }
    }
}
