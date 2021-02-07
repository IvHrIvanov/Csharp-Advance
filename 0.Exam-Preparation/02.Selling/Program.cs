using System;
using System.Collections.Generic;


namespace _02.Selling
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            char[,] matrix = new char[size, size];
            int currentRow = -1;
            int currentColumn = -1;
            int firstPillarRow = -1;
            int firstPillarColumn = -1;
            int secondPillarRow = -1;
            int secondPillarColumn = -1;

            for (int row = 0; row < size; row++)
            {
                char[] tokens = Console.ReadLine().ToCharArray();

                for (int col = 0; col < size; col++)
                {

                    matrix[row, col] = tokens[col];

                    if (matrix[row, col] == 'S')
                    {
                        currentRow = row;
                        currentColumn = col;
                    }
                    else if (matrix[row, col] == 'O')
                    {
                        if (firstPillarRow < 0 && firstPillarColumn < 0)
                        {
                            firstPillarRow = row;
                            firstPillarColumn = col;
                        }
                        else
                        {
                            secondPillarRow = row;
                            secondPillarColumn = col;
                        }
                    }
                }
            }
            int money = 0;
            bool isValid = true;
            while (isValid && money < 50)
            {
                matrix[currentRow, currentColumn] = '-';
                string command = Console.ReadLine();
                if (command == "right")
                {
                    currentColumn++;
                }
                else if (command == "left")
                {
                    currentColumn--;
                }
                else if (command == "down")
                {
                    currentRow++;
                }
                else if (command == "up")
                {
                    currentRow--;
                }
                isValid = currentRow >= 0 && currentRow < size && currentColumn >= 0 && currentColumn < size;
                if (isValid)
                {
                    if (matrix[currentRow, currentColumn] != '-')
                    {
                        if (Char.IsDigit(matrix[currentRow, currentColumn]))
                        {
                            money += (int)Char.GetNumericValue(matrix[currentRow, currentColumn]);

                        }
                        else if (matrix[currentRow, currentColumn] == 'O')
                        {

                            matrix[firstPillarRow, firstPillarColumn] = '-';

                            currentRow = secondPillarRow;
                            currentColumn = secondPillarColumn;
                        }
                    }
                }
            }
            if (money >= 50)
            {
                matrix[currentRow, currentColumn] = 'S';
                Console.WriteLine($"Good news! You succeeded in collecting enough money!");
            }
            else
            {            
                Console.WriteLine("Bad news, you are out of the bakery.");
            }
            Console.WriteLine($"Money: {money}");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}