using System;

namespace IJuniorDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int numberOfMultiple = 0;
            int firstMultipleNumber = 100;
            int lastMultipleNumber = 1000;
            int minNumberRange = 1;
            int maxNumberRange = 28;
            int numberRange = random.Next(minNumberRange, maxNumberRange);
            int tempNumberRange = numberRange;

            while (tempNumberRange < lastMultipleNumber)
            {
                tempNumberRange += numberRange;

                if (tempNumberRange >= firstMultipleNumber)
                {
                    numberOfMultiple++;
                }

            }

            Console.WriteLine($"Кол-во чисел кратных {numberRange} = {numberOfMultiple}");
        }
    }
}
