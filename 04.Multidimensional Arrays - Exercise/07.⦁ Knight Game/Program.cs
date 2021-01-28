using System;

namespace _07.__Knight_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[,] board = new string[n, n];
            int removedKnight = 0;
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                for (int j = 0; j < n; j++)
                {
                    board[i, j] = input[j].ToString();

                }
            }
            while (true)
            {
                int maxAttackKnight = 0;
                int knightRow = -1;
                int knightCol = -1;

                for (int row = 0; row < n; row++)
                {
                    for (int col = 0; col < n; col++)
                    {
                        string symbol = board[row, col];
                        if (symbol != "K")
                        {
                            continue;

                        }
                        int count = GetCountOfAttackedKnight(board, row, col);
                        if (count > maxAttackKnight)
                        {
                            maxAttackKnight = count;
                            knightRow = row;
                            knightCol = col;
                        }
                    }
                }
                    if (maxAttackKnight == 0)
                    {
                        break;
                    }
                    board[knightRow, knightCol] = "0";
                    removedKnight++;
                
            }
            Console.WriteLine(removedKnight);
        }
        private static int GetCountOfAttackedKnight(string[,] board, int row, int col)
        {

            int count = 0;

            if (ContainsKnigt(board, row - 2, col - 1))
            {
                count++;
            }

            if (ContainsKnigt(board, row - 2, col + 1))
            {
                count++;
            }

            if (ContainsKnigt(board, row - 1, col - 2))
            {
                count++;
            }
            if (
                ContainsKnigt(board, row - 1, col + 2))
            {
                count++;
            }

            if (ContainsKnigt(board, row + 1, col - 2))
            {
                count++;
            }

            if (ContainsKnigt(board, row + 1, col + 2))
            {
                count++;
            }

            if (ContainsKnigt(board, row + 2, col - 1))
            {
                count++;
            }

            if (ContainsKnigt(board, row + 2, col + 1))
            {
                count++;
            }
            return count;
        }



        private static bool ContainsKnigt(string[,] board, int row, int col)
        {
            if (!IsValidCell(row, col, board.GetLength(0)))
            {
                return false;
            }
            return board[row, col] == "K";
        }

        private static bool IsValidCell(int row, int col, int lenght)
        {
            return row >= 0 && row < lenght && col >= 0 && col < lenght;
        }

    }



}