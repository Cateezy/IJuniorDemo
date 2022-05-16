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
            int maxNumberForRandom = 5;
            int repeatNumber = 0;
            int countRepeatNumber = 0;
            int tempRepeatNumber;
            int tempCountRepeatNumber = 0;

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(minNumberForRandom, maxNumberForRandom);
                Console.Write($"{array[i]} ");
            }

            tempRepeatNumber = array[0];
            Console.WriteLine();

            for (int i = 0; i < array.Length; i++)
            {

                if (tempRepeatNumber == array[i])
                {
                    tempCountRepeatNumber++;
                }
                else
                {
                    if (tempCountRepeatNumber > countRepeatNumber)
                    {
                        countRepeatNumber = tempCountRepeatNumber;
                        repeatNumber = tempRepeatNumber;
                    }

                    tempCountRepeatNumber = 1;
                    tempRepeatNumber = array[i];
                }

            }

            Console.WriteLine($"Число: {repeatNumber}, Кол-во повторений: {countRepeatNumber}");
        }
    }
}
