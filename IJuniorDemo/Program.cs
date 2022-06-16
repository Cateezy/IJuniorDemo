using System;
using System.Collections.Generic;

namespace IJuniorDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int cashAccount = 0;
            int clientCount = 1;
            int userInput;
            List<int> price = new List<int>() { 100, 200, 300 };
            Queue<int> money = new Queue<int>();
            money.Enqueue(300);
            money.Enqueue(500);
            money.Enqueue(700);

            while (money.Count != 0)
            {
                Console.WriteLine($"Обслуживается клиент №{clientCount}, кол-во денег:{money.Peek()}");
                Console.WriteLine($"Введите 1 для покупки товара №1 с ценой {price[0]}, Введите 2 для покупки товара №2 с ценой {price[1]}");
                Console.WriteLine($"Введите 3 для покупки товара №3 с ценой {price[2]}");
                userInput = Convert.ToInt32(Console.ReadLine());

                switch (userInput)
                {
                    case 1:
                        cashAccount += price[0];
                        break;
                    case 2:
                        cashAccount += price[1];
                        break;
                    case 3:
                        cashAccount += price[2];
                        break;
                }

                Console.WriteLine($"Счет - {cashAccount}");
                money.Dequeue();
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
