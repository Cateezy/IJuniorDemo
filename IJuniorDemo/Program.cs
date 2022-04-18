using System;

namespace IJuniorDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName;
            string lastName;
            int consoleWidth;
            int consoleHeight;
            string userChoose;
            bool cycleIsActive = true;

            while (cycleIsActive)
            {
                Console.WriteLine("Введите SetFirstName - задать имя; SetLastName - задать фамилию");
                Console.WriteLine("ChangeColorFont - изменить цвет текста; ChangeWindowSize - изменить размер окна");
                Console.WriteLine("Clear - очистить консоль, CloseProgramm - завершить программу.");
                userChoose = Console.ReadLine();
                if (userChoose == "SetFirstName")
                {
                    Console.WriteLine("Введите имя: ");
                    firstName = Console.ReadLine();
                }

                if (userChoose == "SetLastName")
                {
                    Console.WriteLine("Введите фамилию: ");
                    lastName = Console.ReadLine();
                }

                if (userChoose == "ChangeColorFont")
                {
                    Console.WriteLine("Введите Red - красный, Green - зеленый, Yellow - желтый цвет шрифта");
                    userChoose = Console.ReadLine();
                    if (userChoose == "Red")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    else if (userChoose == "Green")
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    else if (userChoose == "Yellow")
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    }
                }

                if (userChoose == "Clear")
                {
                    Console.Clear();
                }

                if (userChoose == "SetWindowSize")
                {
                    Console.WriteLine("Введите высоту окна: ");
                    consoleHeight = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите ширину окна: ");
                    consoleWidth = Convert.ToInt32(Console.ReadLine());
                    Console.SetWindowSize(consoleWidth, consoleHeight);
                }

                if (userChoose == "CloseProgramm")
                {
                    cycleIsActive = false;
                }
            }
        }
    }
}
