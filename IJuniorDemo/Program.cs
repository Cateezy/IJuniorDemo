using System;

namespace IJuniorDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int countRoundBrackets = 0;
            int maxDepthRoundBracket = 0;
            char leftRoundBracket = '(';
            char rightRoundBracket = ')';
            string userInput = Console.ReadLine();

            for (int i = 0; i < userInput.Length; i++)
            {

                if (userInput[i] == leftRoundBracket)
                {
                    countRoundBrackets++;
                }

                if (userInput[i] == rightRoundBracket)
                {
                    countRoundBrackets--;
                    maxDepthRoundBracket++;
                }

                if (countRoundBrackets < 0)
                {
                    break;
                }
                
            }

            if (countRoundBrackets == 0)
            {
                Console.WriteLine($"Данное выражение: {userInput} является корректным скобочным выражением, глубина: {maxDepthRoundBracket}");
            }
            else
            {
                Console.WriteLine($"Данное выражение: {userInput} является некорректным скобочным выражением");
            }

        }
    }
}
