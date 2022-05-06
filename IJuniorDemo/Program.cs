using System;

namespace IJuniorDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int numbersInArray = 5;
            int[] array2 = new int[numbersInArray];
            int[] tempArray;
            int tempNumber;
            bool succesInput;
            int sum;
            string userInput;

            Console.WriteLine($"Введите {numbersInArray} чисел");

            for (int i = 0; i < array2.Length; i++)
            {
                userInput = Console.ReadLine();
                succesInput = int.TryParse(userInput, out array2[i]);

                while (!succesInput)
                {
                    Console.WriteLine("Ошибка ввода, введите число");
                    userInput = Console.ReadLine();
                    succesInput = int.TryParse(userInput, out array2[i]);
                }
            }

            for (int i = 0; i < array2.Length; i++)
            {
                Console.Write($"{array2[i]} ");
            }

            Console.WriteLine();

            while (true)
            {
                Console.WriteLine("Введите число чтобы добавить его в массив.\nВведите exit чтобы завершить программу.\nВведите sum чтобы получить сумму всех чисел.");
                userInput = Console.ReadLine();
                succesInput = int.TryParse(userInput, out tempNumber);

                if (succesInput)
                {
                    tempArray = new int[array2.Length + 1];

                    for (int i = 0; i < array2.Length; i++)
                    {
                        tempArray[i] = array2[i];
                    }
                    tempArray[tempArray.Length - 1] = tempNumber;
                    array2 = tempArray;
                }

                if (userInput == "exit")
                {
                    break;
                }

                if (userInput == "sum")
                {
                    sum = 0;

                    for (int i = 0; i < array2.Length; i++)
                    {
                        sum += array2[i];
                    }
                    Console.WriteLine(sum);
                }
            }
        }
    }
}
