using System;

namespace IJuniorDemo
{
    class Program : Example3
    {
        static void Main(string[] args)
        {
            int pictures = 52;
            int limitRowPictures = 3;
            int fullRowsOfPictures = pictures / limitRowPictures;
            int picturesNotInFullRow = pictures % limitRowPictures;

            Console.WriteLine($"Рядов заполнено картинками: {fullRowsOfPictures} , в неполном ряду:  {picturesNotInFullRow}");
        }
    }
}
