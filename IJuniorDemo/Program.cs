using System;

namespace IJuniorDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int numbersInArray = 30;
            int[] array = new int[numbersInArray];
            int firstRandomNumber = 0;
            int lastRandomNumber = 100;

            Console.WriteLine("Исходный массив: ");

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(firstRandomNumber, lastRandomNumber);
                Console.Write($"{array[i]} ");
            }

            Console.WriteLine();

            for (int i = 0; i <= array.Length; i++)
            {

                if (i == 0 && i != numbersInArray - 1)
                {

                    if (array[i] > array[i + 1])
                    {
                        Console.WriteLine($"Локальный максимум: {array[i]}");
                    }

                }
                else if (i != 0 && i == numbersInArray - 1)
                {

                    if (array[i] > array[i - 1])
                    {
                        Console.WriteLine($"Локальный максимум: {array[i]}");
                    }

                }
                else if (i > 1 && i < numbersInArray)
                {

                    if (array[i] > array[i - 1] && array[i] > array[i + 1])
                    {
                        Console.WriteLine($"Локальный максимум: {array[i]}");
                    }
                    
                }

            }

        }
    }
}
