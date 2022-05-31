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
            ResizeArray(ref fullName);
            ResizeArray(ref jobTitle);

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

            ResizeArray(index, ref fullName);
            ResizeArray(index, ref jobTitle);
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

        /// <summary>
        /// Увеличение массива.
        /// </summary>
        /// <param name="array">Массив</param>
        static void ResizeArray(ref string[] array)
        {
            string[] tempArray = new string[array.Length + 1];

            for (int i = 0; i < array.Length; i++)
            {
                tempArray[i] = array[i];
            }

            array = tempArray;
        }

        /// <summary>
        /// Уменьшение массива.
        /// </summary>
        /// <param name="index">Индекс</param>
        /// <param name="array">Массив</param>
        static void ResizeArray(int index, ref string[] array)
        {
            string[] tempArray = new string[array.Length - 1];
            array[index] = null;

            for (int i = 0; i <= tempArray.Length; i++)
            {

                if (array[i] == null)
                {
                    continue;
                }
                else
                {
                    tempArray[i] = array[i];
                }
            }

            array = tempArray;
        }
    }
}
