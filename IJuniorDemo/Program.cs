using System;

namespace IJuniorDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Иванов";
            string lastName = "Иван";
            string temp;
            Console.WriteLine($"Некорректные данные, имя - {firstName}, фамилия - {lastName}");

            temp = firstName;
            firstName = lastName;
            lastName = temp;

            Console.WriteLine($"Корректные данные - имя: {firstName}, фамилия - {lastName}");
        }
    }
}
