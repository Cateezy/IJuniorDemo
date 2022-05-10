using System;

namespace IJuniorDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbersInArray = 5;
            int[] array = new int[numbersInArray];
            int[] tempArray;
            int tempNumber;
            bool succesInput;
            string userInput = "";

            Console.WriteLine($"Введите {numbersInArray} чисел");

            for (int i = 0; i < array.Length; i++)
            {
                userInput = Console.ReadLine();
                succesInput = int.TryParse(userInput, out array[i]);

                while (succesInput == false)
                {
                    Console.WriteLine("Ошибка ввода, введите число");
                    userInput = Console.ReadLine();
                    succesInput = int.TryParse(userInput, out array[i]);
                }
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }

            Console.WriteLine();

            while (userInput != "exit")
            {
                Console.WriteLine("Введите число чтобы добавить его в массив.\nВведите exit чтобы завершить программу.\nВведите sum чтобы получить сумму всех чисел.");
                userInput = Console.ReadLine();
                succesInput = int.TryParse(userInput, out tempNumber);

                if (succesInput)
                {
                    tempArray = new int[array.Length + 1];

                    for (int i = 0; i < array.Length; i++)
                    {
                        tempArray[i] = array[i];
                    }
                    tempArray[tempArray.Length - 1] = tempNumber;
                    array = tempArray;
                }

                if (userInput == "sum")
                {
                    int sum = 0;

                    for (int i = 0; i < array.Length; i++)
                    {
                        sum += array[i];
                    }
                    Console.WriteLine(sum);
                }
            }
        }
    }
}
