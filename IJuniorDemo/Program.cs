using System;

namespace IJuniorDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите кол-во человек в очереди: ");
            int queueCount = Convert.ToInt32(Console.ReadLine());
            int hours;
            int minutes;
            int receiptTime = 10;

            hours = (queueCount * receiptTime) / 60;
            minutes = (queueCount * receiptTime) % 60;
            Console.WriteLine($"Время ожидания в очереди: {hours} часа и {minutes} минут");
            
        }
    }
}
