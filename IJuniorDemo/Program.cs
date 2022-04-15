using System;

namespace IJuniorDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Напишите текст который нужно повторить: ");
            string repeatText = Console.ReadLine();

            Console.WriteLine("Укажите кол-во повторений: ");
            int repeatCount = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < repeatCount; i++)
            {
                Console.WriteLine(repeatText);
            }
        }
    }
}
