using System;
using System.Numerics;

namespace _07.Pascal_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            BigInteger[,] mattrix = new BigInteger[n, n];

            for (int row = 0; row < n; row++)
            {
                mattrix[row, 0] = 1;

                for (int col = 0; col < row; col++)
                {
                    BigInteger current = mattrix[row - 1, col];
                    BigInteger next = mattrix[row - 1, col + 1];
                    mattrix[row, col + 1] = current + next;
                }


            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= i; j++)
                {                  
                    Console.Write(mattrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}