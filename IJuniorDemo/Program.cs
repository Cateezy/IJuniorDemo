using System;

namespace IJuniorDemo
{
    class Program : Example3
    {
        static void Main(string[] args)
        {
            int pictures = 52;
            int limitRowPictures = 3;

            Console.WriteLine($"Рядов заполнено картинками: {pictures / limitRowPictures} , в неполном ряду: {pictures % limitRowPictures}");
        }
    }
}
