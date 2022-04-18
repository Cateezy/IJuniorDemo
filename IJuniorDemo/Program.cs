using System;

namespace IJuniorDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = "12346";
            string secretMessage = "Some text";
            string userAttempt;
            int incorrectAttempt = 0;

            do
            {
                Console.WriteLine("Введите пароль: ");
                userAttempt = Console.ReadLine();

                if (userAttempt == password)
                {
                    Console.WriteLine(secretMessage);
                    break;
                }

                incorrectAttempt++;
            }
            while (incorrectAttempt != 3);

        }
    }
}
