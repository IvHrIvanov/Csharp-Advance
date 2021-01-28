using System;
using System.Linq;

namespace _02._2X2_Squares_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int rowLengt = n[0];
            int colLengt = n[1];

            string[,] mattrix = new string[rowLengt, colLengt];

            for (int i = 0; i < rowLengt; i++)
            {
                string[] input = Console.ReadLine().Split();

                for (int j = 0; j < colLengt; j++)
                {

                    mattrix[i, j] = input[j];

                }
            }


            int count = 0;

            for (int row = 0; row < mattrix.GetLength(0); row++)
            {

                for (int col = 0; col < mattrix.GetLength(1); col++)
                {
                    if (row < rowLengt-1 && col < colLengt-1)
                    {
                        string current = mattrix[row, col];
                        if (mattrix[row, col] == current &&
                            mattrix[row, col + 1] == current &&
                            mattrix[row + 1, col] == current &&
                            mattrix[row + 1, col + 1] == current)
                        {
                            count++;
                        }
                    }

                }
            }
            Console.WriteLine(count);

        }
    }
}