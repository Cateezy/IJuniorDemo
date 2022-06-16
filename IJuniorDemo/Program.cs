using System;
using System.Collections.Generic;

namespace IJuniorDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            string userInput = "";

            while(userInput != "exit")
            {
                Console.WriteLine("Введите число чтобы добавить его в коллекцию. Введите sum, чтобы просуммировать все числа в коллекции.");
                Console.WriteLine("Введите exit, чтобы завершить программу.");
                userInput = Console.ReadLine().ToLower();

                IsInt(userInput, ref numbers);

                if (userInput == "sum")
                {
                    SumNumbers(ref numbers);
                }
            }
        }

        static void IsInt(string userInput, ref List<int> numbers)
        {
            bool isInt = int.TryParse(userInput, out int result);

            if (isInt == true)
            {
                numbers.Add(result);
            }
        }

        static void SumNumbers(ref List<int> numbers)
        {
            int sum = 0;

            foreach (var number in numbers)
            {
                sum += number;
            }

            Console.WriteLine($"Сумма чисел в коллекции:{sum}");
        }
    }
}
