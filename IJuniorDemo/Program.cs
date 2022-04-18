using System;

namespace IJuniorDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = "12346";
            string secretMessage = "Some text";
            string userInput;
            int incorrectAttempt = 3;

            for (int i = 0; i < incorrectAttempt; i++)
            {
                Console.WriteLine("Введите пароль: ");
                userInput = Console.ReadLine();

                if (userInput == password)
                {
                    Console.WriteLine(secretMessage);
                    break;
                }

            }

        }
    }
}
