using System;

namespace IJuniorDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число в строку для преобразования: ");
            int result = ConvertStringNumberToInt();

            Console.WriteLine($"Число: {result}");
        }

        static int ConvertStringNumberToInt()
        {
            string input = Console.ReadLine();
            bool correctInput = Int32.TryParse(input, out int result);

            while (correctInput != true)
            {
                Console.WriteLine("Ошибка! Введите число: ");
                input = Console.ReadLine();
                correctInput = Int32.TryParse(input, out result);
            }

            return result;
        }
    }
}
