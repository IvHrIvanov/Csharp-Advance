using System;
namespace _02_Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            string[,] mattrix = new string[size, size];
            int[] killedShips = new int[2];
            string[] commands = Console.ReadLine().Split(",", StringSplitOptions.RemoveEmptyEntries);
            int playerOneShips = 0;
            int playerTwoShips = 0;
            for (int row = 0; row < size; row++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                for (int col = 0; col < size; col++)
                {
                    string current = input[col].ToString();
                    if (current == "<")
                    {
                        playerOneShips++;
                    }
                    else if (current == ">")
                    {
                        playerTwoShips++;
                    }
                    mattrix[row, col] = current;
                }
            }
            int sunkShips = 0;
            for (int i = 0; i < commands.Length; i++)
            {
                string[] commandsSplited = commands[i].Split(" ", StringSplitOptions.RemoveEmptyEntries);
                int row = int.Parse(commandsSplited[0]);
                int col = int.Parse(commandsSplited[1]);
                bool isValid = IsValid(row, col, size);
                if (isValid)
                {
                    if (i % 2 == 0)
                    {
                        string atackAt = mattrix[row, col];
                        if (atackAt == "#")
                        {
                            KilledShipes(mattrix, row, col, size, killedShips);
                            sunkShips += killedShips[0] + killedShips[1];
                        }
                        else if (mattrix[row, col] == ">")
                        {
                            killedShips[1]++;
                            mattrix[row, col] = "X";
                            sunkShips++;
                        }
                    }
                    else
                    {
                        string atackAt = mattrix[row, col];
                        if (atackAt == "#")
                        {
                            KilledShipes(mattrix, row, col, size, killedShips);
                            sunkShips += killedShips[0] + killedShips[1];
                        }
                        else if (mattrix[row, col] == "<")
                        {
                            killedShips[0]++;
                            mattrix[row, col] = "X";
                            sunkShips++;
                        }
                    }
                    playerOneShips -= killedShips[0];
                    playerTwoShips -= killedShips[1];
                    if (playerOneShips <= 0 || playerTwoShips <= 0)
                    {
                        break;
                    }
                    else
                    {
                        killedShips[0] = 0;
                        killedShips[1] = 0;
                    }
                }
            }
            if (playerTwoShips == 0)
            {
                Console.WriteLine($"Player One has won the game! {sunkShips} ships have been sunk in the battle.");
            }
            else if (playerOneShips == 0)
            {
                Console.WriteLine($"Player Two has won the game! {sunkShips} ships have been sunk in the battle.");

            }
            else
            {
                Console.WriteLine($"It's a draw! Player One has {playerOneShips} left. Player Two has {playerTwoShips} left.");
            }
        }
        private static void KilledShipes(string[,] mattrix, int row, int col, int size, int[] killedShips)
        {
            int rowChek = row - 1;
            int colChek = col - 1;
            bool isValid = IsValid(rowChek, colChek, size);
            if (isValid)
            {
                ChangeArray(mattrix, killedShips, rowChek, colChek);

            }

            rowChek = row - 1;
            colChek = col;
            isValid = IsValid(rowChek, colChek, size);
            if (isValid)
            {
                ChangeArray(mattrix, killedShips, rowChek, colChek);

            }

            rowChek = row - 1;
            colChek = col + 1;
            isValid = IsValid(rowChek, colChek, size);
            if (isValid)
            {
                ChangeArray(mattrix, killedShips, rowChek, colChek);
            }

            rowChek = row;
            colChek = col - 1;
            isValid = IsValid(rowChek, colChek, size);
            if (isValid)
            {
                ChangeArray(mattrix, killedShips, rowChek, colChek);
            }

            rowChek = row;
            colChek = col;
            isValid = IsValid(rowChek, colChek, size);
            if (isValid)
            {
                ChangeArray(mattrix, killedShips, rowChek, colChek);
            }

            rowChek = row;
            colChek = col + 1;
            isValid = IsValid(rowChek, colChek, size);
            if (isValid)
            {
                ChangeArray(mattrix, killedShips, rowChek, colChek);
            }

            rowChek = row + 1;
            colChek = col - 1;
            isValid = IsValid(rowChek, colChek, size);
            if (isValid)
            {
                ChangeArray(mattrix, killedShips, rowChek, colChek);
            }

            rowChek = row;
            colChek = col;
            isValid = IsValid(rowChek, colChek, size);
            if (isValid)
            {
                ChangeArray(mattrix, killedShips, rowChek, colChek);
            }

            rowChek = row + 1;
            colChek = col;
            isValid = IsValid(rowChek, colChek, size);
            if (isValid)
            {
                ChangeArray(mattrix, killedShips, rowChek, colChek);
            }

            rowChek = row + 1;
            colChek = col + 1;
            isValid = IsValid(rowChek, colChek, size);
            if (isValid)
            {
                ChangeArray(mattrix, killedShips, rowChek, colChek);
                mattrix[rowChek, colChek] = "X";
            }
        }
        private static void ChangeArray(string[,] mattrix, int[] killedShips, int rowChek, int colChek)
        {
            if (mattrix[rowChek, colChek] == "<")
            {
                killedShips[0]++;
            }
            else if (mattrix[rowChek, colChek] == ">")
            {
                killedShips[1]++;
            }
            mattrix[rowChek, colChek] = "X";
        }
        private static bool IsValid(int firstComand, int secondComand, int size)
        {
            return firstComand >= 0 && firstComand < size && secondComand >= 0 && secondComand < size;
        }
    }
}