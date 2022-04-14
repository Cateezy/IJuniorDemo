using System;

namespace IJuniorDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Укажите кол-во золота: ");
            int gold = Convert.ToInt32(Console.ReadLine());
            int crystals;
            int crystalCost = 120;
            int countOfPurchasedCrystals;
            int fullOfPurchasedCrystals;

            Console.WriteLine($"Укажите кол-во кристалов для покупки. Стоимость одного кристала - {crystalCost}");
            countOfPurchasedCrystals = Convert.ToInt32(Console.ReadLine());
            fullOfPurchasedCrystals = crystalCost * countOfPurchasedCrystals;
            crystals = fullOfPurchasedCrystals;
            gold -= fullOfPurchasedCrystals;
            crystals /= crystalCost;
            
            Console.WriteLine($"Кол-во кристалов - {crystals}, кол-во оставшегося золота {gold}");
        }
    }
}
