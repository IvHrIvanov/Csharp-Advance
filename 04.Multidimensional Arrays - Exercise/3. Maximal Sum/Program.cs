using System;
using System.Linq;

namespace _3._Maximal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            int rowLengh = input[0];
            int colLengh = input[1];

            int[,] mattrix = new int[rowLengh, colLengh];
            
            for (int i = 0; i < rowLengh; i++)
            {
                int[] add = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                for (int j = 0; j < colLengh; j++)
                {

                    mattrix[i, j] = add[j];
                }
            }

            int rowIndex = 0;
            int colIndex = 0;
            int totalSum = 0;
            for (int row = 0; row < rowLengh; row++)
            {

                for (int col = 0; col < colLengh; col++)
                {
                    if (row + 2 < rowLengh && col + 2 < colLengh)
                    {
                        int sumFirstRow = mattrix[row, col] + mattrix[row, col + 1] + mattrix[row, col + 2];
                        int sumSecondRow = mattrix[row + 1, col] + mattrix[row + 1, col + 1] + mattrix[row + 1, col + 2];
                        int sumThirdRow = mattrix[row + 2, col] + mattrix[row + 2, col + 1] + mattrix[row + 2, col + 2];
                        int sum = sumFirstRow + sumSecondRow + sumThirdRow;

                        if (totalSum < sum)
                        {
                            rowIndex = row;
                            colIndex = col;
                            totalSum = sum;
                        }
                    }
                }
            }
            Console.WriteLine($"Sum = {totalSum}");
            for (int currentRow = rowIndex; currentRow <= rowIndex + 2; currentRow++)
            {

                for (int currentCol = colIndex; currentCol <= colIndex + 2; currentCol++)
                {
                    Console.Write(mattrix[currentRow, currentCol] + " ");
                }
                Console.WriteLine();
            }


        }
    }
}
