using System;

namespace IJuniorDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int randomMaxValue = 1000;
            int baseNumber = random.Next(randomMaxValue);
            int degreeOfNumber = 1;
            int baseDegreeOfNumber = 2;
            int numberRaisedToDegree = 0;

            while (baseNumber > numberRaisedToDegree)
            {
                numberRaisedToDegree = Convert.ToInt32(Math.Pow(baseDegreeOfNumber, degreeOfNumber));
                degreeOfNumber++;
            }

            Console.WriteLine($"Начальное число: {baseNumber}, число 2 в степени {degreeOfNumber} = {numberRaisedToDegree}");
            
        }
    }
}
