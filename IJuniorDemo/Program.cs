using System;
using System.IO;

namespace IJuniorDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] {1, 2, 3, 4, 5};

            Shuffle(array);

            foreach (var index in array)
            {
                Console.Write($"{index} ");
            }
        }

        static void Shuffle(int[] array)
        {
            Random random = new Random();
            int index;
            int temp;

            for (int i = array.Length - 1; i >= 1; i--)
            {
                index = random.Next(i + 1);
                temp = array[index];
                array[index] = array[i];
                array[i] = temp;
            }
        }
    }
}
