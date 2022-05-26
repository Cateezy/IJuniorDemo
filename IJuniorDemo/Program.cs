using System;

namespace IJuniorDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "One Two Three Four";
            string[] textArray = text.Split(' ');

            for (int i = 0; i < textArray.Length; i++)
            {
                Console.WriteLine($"{textArray[i]} ");
            }
        }
    }
}
