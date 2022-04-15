using System;

namespace IJuniorDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите кол-во человек в очереди: ");
            int queueCount = Convert.ToInt32(Console.ReadLine());
            int hoursWaiting;
            int minutesWaiting;
            int receiptTime = 10;
            int minutesInHour = 60;

            hoursWaiting = (queueCount * receiptTime) / minutesInHour;
            minutesWaiting = (queueCount * receiptTime) % minutesInHour;
            Console.WriteLine($"Время ожидания в очереди: {hoursWaiting} часа и {minutesWaiting} минут");
            
        }
    }
}
