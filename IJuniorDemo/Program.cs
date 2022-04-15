using System;

namespace IJuniorDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int increasedNumber = 5;
            int increasedLastNumber = 103;
            int increaseStep = 7;

            while (increasedNumber != increasedLastNumber)
            {
                Console.Write(increasedNumber + " ");
                increasedNumber += increaseStep;
            }
            
        }
    }
}
