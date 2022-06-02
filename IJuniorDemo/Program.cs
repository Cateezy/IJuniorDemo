using System;

namespace IJuniorDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int health = 5;
            int maxHealth = 10;
            int mana = 3;
            int maxMana = 10;

            DrawBar(health, maxHealth, '$', 0);
            DrawBar(mana, maxMana,'#', 1);
            Console.WriteLine();
        }

        static void DrawBar(int value, int maxValue, char symbol, int positionY)
        {
            string bar = "";

            for (int i = 0; i < value; i++)
            {
                bar += symbol;
            }

            Console.SetCursorPosition(0, positionY);
            Console.Write($"[{bar}");
            bar = "";

            for (int i = value; i < maxValue; i++)
            {
                bar += '_';
            }

            Console.Write($"{bar}]");
        }
    }
}
