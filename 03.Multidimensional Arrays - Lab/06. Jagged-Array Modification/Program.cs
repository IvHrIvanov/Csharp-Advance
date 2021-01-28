using System;
using System.Linq;

namespace _06._Jagged_Array_Modification
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            int[,] mattrix = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

                for (int j = 0; j < n; j++)
                {
                    mattrix[i, j] = input[j];
                }
            }
            string[] command = Console.ReadLine().Split(" ");

            while (command[0] != "END")
            {

                int row = int.Parse(command[1]);
                int col = int.Parse(command[2]);
                int addOrSubstract = int.Parse(command[3]);

                if (row < 0 || row >= n || col >= n || col < 0)
                {
                    Console.WriteLine("Invalid coordinates");
                }
                else
                {

                    if (command[0] == "Add")
                    {
                        AddToNumber(row, col, addOrSubstract, mattrix);
                    }
                    else if (command[0] == "Subtract")
                    {
                        SubtractToNumber(row, col, addOrSubstract, mattrix);
                    }
                }


                command = Console.ReadLine().Split(" ");
            }

            for (int row = 0; row < n; row++)
            {


                for (int col = 0; col < n; col++)
                {
                    Console.Write(mattrix[row,col]+" ");
                }
                Console.WriteLine();
            }

        }

        private static void SubtractToNumber(int rows, int cols, int addOrSubstract, int[,] mattrix)
        {
            for (int row = rows; row <= rows; row++)
            {

                for (int col = cols; col <= cols; col++)
                {
                    mattrix[row, col] -= addOrSubstract;
                }
            }
        }

        private static void AddToNumber(int rows, int cols, int addOrSubstract, int[,] matrix)
        {
            for (int row = rows; row <= rows; row++)
            {

                for (int col = cols; col <= cols; col++)
                {
                    matrix[row, col] += addOrSubstract;
                }
            }
        }
    }
}