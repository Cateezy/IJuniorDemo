using System;

namespace IJuniorDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите имя: ");
            string name = Console.ReadLine();
            Console.WriteLine("Введите символ: ");
            char symbol = Convert.ToChar(Console.ReadLine());

            for (int i = 0; i <= name.Length + 1; i++)
            {
                Console.Write(symbol);
            }
            Console.WriteLine();
            Console.WriteLine($"{symbol}{name}{symbol}");

            for (int i = 0; i <= name.Length + 1; i++)
            {
                Console.Write(symbol);
            }
            Console.ReadKey();
        }
    }
}
