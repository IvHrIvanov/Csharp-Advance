using System;
using System.Linq;

namespace _02.Garden
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int n = size[0];
            int m = size[1];
            int[,] garden = new int[n, m];


            string command = Console.ReadLine();
            while (command != "Bloom Bloom Plow")
            {

                int[] numbers = command.Split(" ").Select(int.Parse).ToArray();
                int rowIndex = numbers[0];
                int colIndex = numbers[1];
                bool isvalid = IsValid(rowIndex, colIndex, m, n);
                if (isvalid)
                {

                    Plunder(garden, rowIndex, colIndex);
                }
                else
                {
                    Console.WriteLine("Invalid coordinates.");
                }
                command = Console.ReadLine();
            }
            for (int i = 0; i < garden.GetLength(0); i++)
            {
                for (int j = 0; j < garden.GetLength(1); j++)
                {
                    Console.Write(garden[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        private static bool IsValid(int rowIndex, int colIndex, int m, int n)
        {
            return rowIndex >= 0 && rowIndex < n && colIndex >= 0 && colIndex < n;
        }

        private static void Plunder(int[,] garden, int rowIndex, int colIndex)
        {

            garden[rowIndex, colIndex]++;
            for (int row = rowIndex + 1; row <= garden.GetLength(0); row++)
            {
                if (row + 1 > garden.GetLength(0))
                {
                    for (int i = 0; i < rowIndex; i++)
                    {
                        garden[i, colIndex]++;
                    }
                    break;
                }

                garden[row, colIndex]++;

            }


            for (int col = colIndex + 1; col <= garden.GetLength(1); col++)
            {
                if (col + 1 > garden.GetLength(1))
                {
                    for (int i = 0; i < colIndex; i++)
                    {
                        garden[rowIndex, i]++;
                    }
                    break;
                }

                garden[rowIndex, col]++;

            }

        }
    }
}