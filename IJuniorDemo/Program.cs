using System;

namespace IJuniorDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int cycleCounter = 0;
            string cycleStopLetter = "Exit";
            string cycleReceivedLetter = "";

            while (cycleStopLetter != cycleReceivedLetter)
            {
                Console.WriteLine(cycleCounter++);
                Console.WriteLine("Для завершения цикла введите 'Exit', для продолжения нажмите Enter");
                cycleReceivedLetter = Console.ReadLine();
            }

            Console.WriteLine("Выход из цикла");
        }
    }
}
