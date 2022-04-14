using System;

namespace IJuniorDemo
{
    public class Example3
    {
        
        public static void WorkWithString()
        {
            Console.WriteLine("Введите свое имя: ");
            string name = Console.ReadLine();
            Console.WriteLine("Вверидте возраст: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ввеедите место работы: ");
            string job = Console.ReadLine();
            Console.WriteLine("Укажите хобби: ");
            string hobby = Console.ReadLine();

            Console.WriteLine($"Вас зовут - {name}, Вам {age} лет, место работы {job}, любимое занятие {hobby}");
        }
    }
}