using System;
using System.Collections.Generic;
using System.IO;

namespace IJuniorDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> meaningWords = new Dictionary<string, string>();
            meaningWords.Add("Программи́рование", "Процесс создания компьютерных программ");
            meaningWords.Add("Программист", "специалист, занимающийся программированием, то есть созданием компьютерных программ");

            GetValue(meaningWords);
        }

        static void GetValue(Dictionary<string, string> meaningWords)
        {
            Console.WriteLine("Введите слово, чтобы получить значение: ");
            string userInput = Console.ReadLine();

            if (meaningWords.ContainsKey(userInput))
            {
                Console.WriteLine($"Значение слова {meaningWords[userInput]}.");
            }
            else
            {
                Console.WriteLine("Слово отсутствует в словаре.");
            }
        }
    }
}
