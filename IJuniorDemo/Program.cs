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
            int cycleCounter = 1;
            Console.WriteLine($"Сгенерированное число: {number}");

            while (cycleCounter <= number)
            {
                if (cycleCounter % multiplesThree == 0 || cycleCounter % multiplesFive == 0)
                {
                    multiplesSum += cycleCounter;
                    Console.Write(cycleCounter + " ");
                }
                cycleCounter++;
            }
            Console.WriteLine();
            Console.WriteLine($"Сумма всех чисел кратных 3 и 5: {multiplesSum}");

        }
    }
}
