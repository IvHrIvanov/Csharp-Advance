using System;
using System.Linq;

namespace _4._Matrix_Shuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            int rowLenght = n[0];
            int colLenght = n[1];

            string[,] mattrix = new string[rowLenght, colLenght];

            for (int i = 0; i < rowLenght; i++)
            {
                string[] input = Console.ReadLine().Split(" ");

                for (int j = 0; j < colLenght; j++)
                {
                    mattrix[i, j] = input[j];
                }
            }

            string[] command = Console.ReadLine().Split(" ");

            while (command[0] != "END")
            {
                bool flag = false;
                if (command[0] == "swap" && command.Length == 5)
                {

                    int oldRow = int.Parse(command[1]);
                    int oldCol = int.Parse(command[2]);
                    int newRow = int.Parse(command[3]);
                    int newCol = int.Parse(command[4]);
                    if (oldRow < rowLenght &&
                        oldCol < colLenght &&
                        newRow < rowLenght &&
                        newCol < colLenght &&
                        oldRow >= 0 &&
                        oldCol >= 0 &&
                        newRow >= 0 &&
                        newCol >= 0)
                    {

                        string oldMattrix = mattrix[oldRow, oldCol];
                        string newMattrix = mattrix[newRow, newCol];

                        mattrix[oldRow, oldCol] = newMattrix;
                        mattrix[newRow, newCol] = oldMattrix;
                        flag = true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
                if (flag)
                {
                    for (int row = 0; row < rowLenght; row++)
                    {
                        for (int col = 0; col < colLenght; col++)
                        {
                            Console.Write(mattrix[row, col] + " ");
                        }
                        Console.WriteLine();
                    }
                }
                command = Console.ReadLine().Split(" ");
            }

        }
    }
}
