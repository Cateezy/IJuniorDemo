using System;
using System.IO;

namespace IJuniorDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int playerPositionX;
            int playerPositionY;
            int directionX = 0;
            int directionY = 0;
            bool isPlaying = true;
            char[,] map = ReadMap("map1.txt", out playerPositionX, out playerPositionY);
            DrawMap(map);
            DrawPlayer(ref playerPositionX, ref playerPositionY);
            Console.CursorVisible = false;
            
            while (isPlaying)
            {
                GetDirection(ref directionX, ref directionY);
                ChangePlayerPosition(map, ref playerPositionX, ref playerPositionY, ref directionX, ref directionY);
            }
        }

        static char[,] ReadMap(string path, out int playerPositionX, out int playerPositionY)
        {
            playerPositionX = 0;
            playerPositionY = 0;
            string[] tempMap = File.ReadAllLines(path);
            char[,] map = new char[tempMap.Length, tempMap[0].Length];

            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    map[i, j] = tempMap[i][j];

                    if (map[i, j] == '@')
                    {
                        playerPositionX = i;
                        playerPositionY = j;
                    }
                }
            }

            return map;
        }

        static void DrawMap(char[,] map)
        {
            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    Console.Write(map[i, j]);
                }
                Console.WriteLine();
            }
        }

        static void DrawPlayer(ref int playerPositionX, ref int playerPositionY)
        {
            Console.SetCursorPosition(playerPositionY, playerPositionX);
            Console.Write('@');
        }

        static void GetDirection(ref int directionX, ref int directionY)
        {
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo key = Console.ReadKey(true);

                switch (key.Key)
                {
                    case ConsoleKey.W:
                        directionX = -1;
                        directionY = 0;
                        break;
                    case ConsoleKey.S:
                        directionX = 1;
                        directionY = 0;
                        break;
                    case ConsoleKey.A:
                        directionX = 0;
                        directionY = -1;
                        break;
                    case ConsoleKey.D:
                        directionX = 0;
                        directionY = 1;
                        break;
                }
            }
        }

        static void ChangePlayerPosition(char[,] map, ref int playerPositionX, ref int playerPositionY, ref int directionX, ref int directionY)
        {
            if (map[playerPositionX + directionX, playerPositionY + directionY] != '#')
            {
                Console.SetCursorPosition(playerPositionY, playerPositionX);
                Console.Write(" ");

                playerPositionX += directionX;
                playerPositionY += directionY;

                DrawPlayer(ref playerPositionX, ref playerPositionY);
            }
        }
    }
}
