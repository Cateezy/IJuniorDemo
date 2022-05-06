using System;

namespace IJuniorDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfColumns = 10;
            int numberOfLines = 10;
            int[,] array = new int[numberOfLines, numberOfColumns];
            int firstRandomNumber = 0;
            int lastRandomNumber = 10;
            int maxNumber = 0;
            Random random = new Random();

            Console.WriteLine("Исходный массив: ");

            for (int i = 0; i < array.GetLength(0); i++)
            {

                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = random.Next(firstRandomNumber, lastRandomNumber);
                    Console.Write(array[i, j] + " ");
                }

                Console.WriteLine();

            }

            for (int i = 0; i < array.GetLength(0); i++)
            {

                for (int j = 0; j < array.GetLength(1); j++)
                {

                    if (maxNumber < array[i,j])
                    {
                        maxNumber = array[i, j];
                    }

                }

            }

            Console.WriteLine("Измененный массив: ");

            for (int i = 0; i < array.GetLength(0); i++)
            {

                for (int j = 0; j < array.GetLength(1); j++)
                {

                    if (maxNumber == array[i, j])
                    {
                        array[i, j] = 0;
                    }

                    Console.Write(array[i, j] + " ");
                }

                Console.WriteLine();
            }

            Console.WriteLine($"Максимальное число: {maxNumber}");
        }
    }
}
