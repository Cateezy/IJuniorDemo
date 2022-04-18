using System;

namespace IJuniorDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите кол-во рублей: ");
            double rubleBalance = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите кол-во долларов: ");
            double dollarBalance = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите кол-во евро: ");
            double euroBalance = Convert.ToDouble(Console.ReadLine());

            double courseRubleToDollar = 60;
            double courseRubleToEuro = 70;
            double courseDollarToRuble = 0.016;
            double courseDollarToEuro = 0.085;
            double courseEuroToRuble = 0.014;
            double courseEuroToDollar = 1.16;

            int userChoose;
            bool cycleIsActive = true;
            while (cycleIsActive)
            {
                Console.WriteLine("Введите 1 - перевести рубли в доллары, 2 - перевести рубли в евро");
                Console.WriteLine("Введите 3 - перевести доллары в рубли, 4 - перевести доллары в евро");
                Console.WriteLine("Введите 5 - перевести евро в рубли, 6 - перевести евро в доллары");
                Console.WriteLine("Введите 7 - закончить программу");
                userChoose = Convert.ToInt32(Console.ReadLine());
                double temp;
                switch (userChoose)
                {
                    case 1:
                        Console.WriteLine("Введите кол-во рублей для перевода");
                        temp = Convert.ToDouble(Console.ReadLine());
                        rubleBalance -= temp;
                        dollarBalance += temp / courseRubleToDollar;
                        Console.WriteLine($"Баланс долларов: {dollarBalance}");
                        break;
                    case 2:
                        Console.WriteLine("Введите кол-во рублей для перевода");
                        temp = Convert.ToDouble(Console.ReadLine());
                        rubleBalance -= temp;
                        euroBalance += temp / courseRubleToEuro;
                        Console.WriteLine($"Баланс евро: {euroBalance}");
                        break;
                    case 3:
                        Console.WriteLine("Введите кол-во долларов для перевода");
                        temp = Convert.ToDouble(Console.ReadLine());
                        dollarBalance -= temp;
                        rubleBalance += temp / courseDollarToRuble;
                        Console.WriteLine($"Баланс рублей: {rubleBalance}");
                        break;
                    case 4:
                        Console.WriteLine("Введите кол-во долларов для перевода");
                        temp = Convert.ToDouble(Console.ReadLine());
                        dollarBalance -= temp;
                        euroBalance += temp / courseDollarToEuro;
                        Console.WriteLine($"Баланс евро: {euroBalance}");
                        break;
                    case 5:
                        Console.WriteLine("Введите кол-во евро для перевода");
                        temp = Convert.ToDouble(Console.ReadLine());
                        euroBalance -= temp;
                        rubleBalance += temp / courseEuroToRuble;
                        Console.WriteLine($"Баланс рублей: {rubleBalance}");
                        break;
                    case 6:
                        Console.WriteLine("Введите кол-во евро для перевода");
                        temp = Convert.ToDouble(Console.ReadLine());
                        euroBalance -= temp;
                        dollarBalance += temp / courseEuroToDollar;
                        Console.WriteLine($"Баланс долларов: {dollarBalance}");
                        break;
                    case 7:
                        cycleIsActive = false;
                        Console.WriteLine($"Баланс рублей: {rubleBalance}\nБаланс долларов: {dollarBalance}\nБаланс евро: {euroBalance}");
                        break;
                }
                
            }
            Console.ReadKey();
        }
    }
}
