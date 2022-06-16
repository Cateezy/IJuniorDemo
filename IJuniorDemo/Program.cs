using System;
using System.Collections.Generic;

namespace IJuniorDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int cashAccount = 0;
            int clientNumber = 1;
            Queue<int> money = new Queue<int>();
            money.Enqueue(300);
            money.Enqueue(500);
            money.Enqueue(700);

            while (money.Count != 0)
            {
                Console.WriteLine($"Обслуживается клиент №{clientNumber}, сумма:{money.Peek()}");
                cashAccount += money.Peek();
                clientNumber++;
                Console.WriteLine($"Счет - {cashAccount}");
                money.Dequeue();
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
