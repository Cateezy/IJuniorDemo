using System;

namespace IJuniorDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fullName = new string[0];
            string[] jobTitle = new string[0];
            int userInput = 0;

            while (userInput != 5)
            {
                Console.WriteLine("Введите 0, чтобы очистить консоль; Введите 1, чтобы добавить досье; Введите 2, чтобы напечатать все досье; ");
                Console.WriteLine("Введите 3, чтобы удалить досье по индексу; Введите 4, чтобы найти досье по фамилии; Введите 5, чтобы завершить программу.");
                userInput = Convert.ToInt32(Console.ReadLine());

                switch (userInput)
                {
                    case 0:
                        Console.Clear();
                        break;
                    case 1:
                        AddDossier(ref fullName, ref jobTitle);
                        break;
                    case 2:
                        PrintAllDossiers(fullName, jobTitle);
                        break;
                    case 3:
                        DeleteDossier(ref fullName, ref jobTitle);
                        break;
                    case 4:
                        FindByLastName(fullName, jobTitle);
                        break;
                    case 5:
                        break;

                }
            }
        }

        static void AddDossier(ref string[] fullName, ref string[] jobTitle)
        {
            string[] tempFullName = new string[fullName.Length + 1];
            string[] tempJobTitle = new string[jobTitle.Length + 1];

            for (int i = 0; i < jobTitle.Length; i++)
            {
                tempJobTitle[i] = jobTitle[i];
                tempFullName[i] = fullName[i];
            }

            fullName = tempFullName;
            jobTitle = tempJobTitle;

            Console.WriteLine("Введите ФИО через пробел: ");
            fullName[fullName.Length - 1] = Console.ReadLine();
            Console.WriteLine("Введите должность: ");
            jobTitle[jobTitle.Length - 1] = Console.ReadLine();           
        }

        static void PrintAllDossiers(string[] fullName, string[] jobTitle)
        {

            for (int i = 0; i < fullName.Length; i++)
            {
                Console.WriteLine($"{i + 1} - {fullName[i]} - {jobTitle[i]}");
            }
        }

        static void DeleteDossier(ref string[] fullName, ref string[] jobTitle)
        {
            Console.WriteLine($"Введите индекс от 0 до {fullName.Length - 1} включительно.");
            int index = Convert.ToInt32(Console.ReadLine());

            if (index > fullName.Length - 1)
            {
                Console.WriteLine($"Неверно указан индекс, индекс должен быть от 0 до {fullName.Length - 1} включительно.\nВозврат в меню.");
                return;
            }

            string[] tempFullName = new string[fullName.Length - 1];
            string[] tempJobTitle = new string[jobTitle.Length - 1];
            fullName[index] = null;
            jobTitle[index] = null;

            for (int i = 0; i <= tempFullName.Length; i++)
            {

                if (fullName[i] == null && jobTitle[i] == null)
                {
                    continue;
                }
                else
                {
                    tempFullName[i] = fullName[i];
                    tempJobTitle[i] = jobTitle[i];
                }
            }

            fullName = tempFullName;
            jobTitle = tempJobTitle;
        }

        static void FindByLastName(string[] fullName, string[] jobTitle)
        {
            string[] tempSplitFullName;
            Console.WriteLine("Введите фамилию для поиска: ");
            string lastName = Console.ReadLine();

            for (int i = 0; i < fullName.Length; i++)
            {
                tempSplitFullName = fullName[i].Split(' ');

                if (tempSplitFullName[0].ToLower() == lastName.ToLower())
                {
                    Console.WriteLine($"Номер: {fullName.Length - 1} ФИО: {fullName[i]} Должность: {jobTitle[i]}");
                    return;
                }
            }

            Console.WriteLine("Такой фамилии нет в базе.");
        }
    }
}
