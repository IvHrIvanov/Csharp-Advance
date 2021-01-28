using System;

namespace _04._Symbol_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[,] matrix = new string[n, n];
       
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = input[j].ToString();
                }

            }

            string symbol = Console.ReadLine();

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    string current = matrix[row, col];

                    if (current == symbol)
                    {
                        Console.WriteLine($"({row}, {col})");
                        Environment.Exit(0);
                    }

                }
            }

            Console.WriteLine($"{symbol} does not occur in the matrix");

        }
    }
}