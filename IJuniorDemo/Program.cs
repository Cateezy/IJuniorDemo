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
            if (dossier.Count > 0)
            {

                foreach (string userInfo in dossier)
                {
                    Console.WriteLine(userInfo);
                }
            }
            else
            {
                Console.WriteLine("Нет информации для вывода, список пуст");
            }
        }

        static void DeleteDossier(List<string> dossier)
        {
            Console.WriteLine($"Введите номер досье которое нужно удалить, от 0 до {dossier.Count - 1}");
            int index = 0;
            bool isInt = false;

            while (isInt == false)
            {
                isInt = int.TryParse(Console.ReadLine(), out index);

                if (isInt == false)
                {
                    Console.WriteLine("Введено не число, повторите ввод: ");
                }

                if (index >= dossier.Count || index < 0)
                {
                    Console.WriteLine("Индекс отсутсвует в списке, введите индекс находящийся в списке.");
                    isInt = false;
                }
            }
            
            dossier.RemoveAt(index);
        }
    }
}
