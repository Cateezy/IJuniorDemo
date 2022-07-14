using System;
using System.Collections.Generic;

namespace IJuniorDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> dossier = new List<string>();
            string userInput = "";

            while (userInput != "exit")
            {
                Console.WriteLine("Введите add чтобы добавить досье. Введите print чтобы вывести все досье.\nВведите delete чтобы удалить досье. Введите exit чтобы выйти из программы.");
                userInput = Console.ReadLine().ToLower();

                if (userInput == "add")
                {
                    AddDossier(dossier);
                }
                else if (userInput == "print")
                {
                    PrintAllDossier(dossier);
                }
                else if (userInput == "delete")
                {
                    DeleteDossier(dossier);
                }
            }
        }

        static void AddDossier(List<string> dossier)
        {
            Console.WriteLine("Введите ФИО: ");
            string fullName = Console.ReadLine();
            Console.WriteLine("Введите должность: ");
            string jobTitle = Console.ReadLine();
            dossier.Add(fullName + " - " + jobTitle);
        }

        static void PrintAllDossier(List<string> dossier)
        {
            foreach (string userInfo in dossier)
            {
                Console.WriteLine(userInfo);
            }
        }

        static void DeleteDossier(List<string> dossier)
        {
            Console.WriteLine($"Введите номер досье которое нужно удалить, от 0 до {dossier.Count - 1}");
            string userInput = Console.ReadLine();
            int index = 0;
            bool isInt = false;

            while (isInt == false)
            {
                isInt = int.TryParse(userInput, out index);

                if (isInt == false)
                {
                    Console.WriteLine("Введено не число, повторите ввод: ");
                    userInput = Console.ReadLine();
                }
            }
            
            dossier.RemoveAt(index);
        }
    }
}
