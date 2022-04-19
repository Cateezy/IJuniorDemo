using System;

namespace IJuniorDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int countLeftRoundBracket = 0;
            int countRightRoundBracket = 0;
            string userInput = Console.ReadLine();

            for (int i = 0; i < userInput.Length; i++)
            {
                char tempLeftRoundBracket = '(';
                char tempRightRoundBracket = ')';

                if (tempRightRoundBracket == userInput[0])
                {
                    countRightRoundBracket++;
                    break;
                }

                if (tempRightRoundBracket == userInput[i])
                {
                    countRightRoundBracket++;
                }
                else if(tempLeftRoundBracket == userInput[i])
                {
                    countLeftRoundBracket++;
                }

            }

            if (countLeftRoundBracket == countRightRoundBracket)
            {
                Console.WriteLine($"Данное выражение: {userInput} является корректным скобочным выражением");
            }
            else
            {
                Console.WriteLine($"Данное выражение: {userInput} является некорректным скобочным выражением");
            }

        }
    }
}
