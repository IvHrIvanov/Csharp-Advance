using System;
using System.Linq;

namespace _1._Sum_Matrix_Elements
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] size = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();


            int rows = size[0];
            int col = size[1];

            int[,] matrix = new int[rows, col];

            for (int row = 0; row < rows; row++)
            {
                int[] input = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

                for (int cols = 0; cols < col; cols++)
                {

                    matrix[row, cols] = input[cols];

                }

            }
            int sum = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    sum += matrix[i, j];
                }

            }

            Console.WriteLine(matrix.GetLength(0));
            Console.WriteLine(matrix.GetLength(1));
            Console.WriteLine(sum);
        }
    }
}
