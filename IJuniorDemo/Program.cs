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
            bool isInt;
            int sum = 0;

            while(userInput != "exit")
            {
                Console.WriteLine("Введите add, чтобы добавить число. Введите sum, чтобы просуммировать все числа в коллекции. Введите exit, чтобы завершить программу.");
                userInput = Console.ReadLine().ToLower();

                if (userInput == "add")
                {
                    Console.WriteLine("Введите число: ");
                    userInput = Console.ReadLine();
                    isInt = int.TryParse(userInput, out int result);

                    while (isInt != true)
                    {
                        Console.WriteLine("Вы ввели не число! Повторите ввод: ");
                        userInput = Console.ReadLine();
                        isInt = int.TryParse(userInput, out result);
                    }

                    numbers.Add(result);
                }

                if (userInput == "sum")
                {

                    foreach (var number in numbers)
                    {
                        sum += number;
                    }

                    Console.WriteLine($"Сумма чисел в коллекции:{sum}");
                }
            }
        }
    }
}
