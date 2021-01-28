using System;
using System.Linq;

namespace _05.__Snake_Moves
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] n = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            int rowLenght = n[0];
            int colLengt = n[1];
            string[,] mattrix = new string[rowLenght, colLengt];
            string input = Console.ReadLine();

            int backCout = 0;

            for (int row = 0; row < mattrix.GetLength(0); row++)
            {
                if (row >= rowLenght)
                {
                    break;
                }

                for (int col = 0; col < mattrix.GetLength(1); col++)
                {
                    if (backCout >= input.Length)
                    {
                        backCout = 0;
                    }
                    mattrix[row, col] = input[backCout].ToString();
                    backCout++;

                }

                if (row + 1 >= rowLenght)
                {
                    break;
                }
                for (int colBack = colLengt - 1; colBack >= 0; colBack--)
                {

                    if (backCout >= input.Length)
                    {
                        backCout = 0;
                    }

                    mattrix[row + 1, colBack] = input[backCout].ToString();
                    backCout++;

                }
                row++;


            }

            for (int row = 0; row < rowLenght; row++)
            {

                for (int col = 0; col < colLengt; col++)
                {
                    Console.Write(mattrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}