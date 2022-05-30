using System;

namespace IJuniorDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 2, 3, 4, 5 };
            Console.WriteLine("Введите число на которое сдвинется массив влево: ");
            int step = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < step; i++)
            {
                int temp = array[0];

                for (int j = 0; j < array.Length - 1; j++)
                {
                    array[j] = array[j + 1];
                }
                
                array[array.Length - 1] = temp;
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
        }
    }
}
