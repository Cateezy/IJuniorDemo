using System;

namespace IJuniorDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[5, 5];
            int productOfFirstColumn = 1;
            int sumOfSecondLine = 0;
            int firstRandomNumber = 0;
            int lastRandomNumber = 10;
            Random random = new Random();

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
                int temp = array[i, 0];
                productOfFirstColumn *= temp;
            }

            Console.WriteLine($"Произведение первого столбца: {productOfFirstColumn}");

            for (int i = 0; i < array.GetLength(1); i++)
            {
                int temp = array[1, i];
                sumOfSecondLine += temp;
            }

            Console.WriteLine($"Сумма второй строки: {sumOfSecondLine}");
        }
    }
}
