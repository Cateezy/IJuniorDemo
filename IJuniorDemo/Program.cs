using System;

namespace IJuniorDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int number = random.Next(0, 100);
            int multiplesThree = 3;
            int multiplesFive = 5;
            int multiplesSum = 0;
            Console.WriteLine($"Сгенерированное число: {number}");

            for (int i = 1; i < number; i++)
            {
                if (i % multiplesThree == 0 || i % multiplesFive == 0)
                {
                    multiplesSum += i;
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
            Console.WriteLine($"Сумма всех чисел кратных 3 и 5: {multiplesSum}");

        }
    }
}
