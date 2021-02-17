using System;

namespace _02_Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            char[,] mattrix = new char[size, size];

            int rowSnakePosition = 0;
            int colSnakePosition = 0;
            int[] firstPositionB = new int[2];
            int[] secondPositionB = new int[2];
            int positionOfB = 0;
            for (int row = 0; row < size; row++)
            {
                string input = Console.ReadLine();
                for (int col = 0; col < size; col++)
                {
                    if (input[col] == 'S')
                    {
                        rowSnakePosition = row;
                        colSnakePosition = col;
                    }
                    if (positionOfB == 0 && input[col] == 'B')
                    {
                        firstPositionB[0] = row;
                        firstPositionB[1] = col;
                        positionOfB++;
                    }
                    else if (positionOfB == 1 && input[col] == 'B')
                    {
                        secondPositionB[0] = row;
                        secondPositionB[1] = col;
                        positionOfB++;
                    }

                    mattrix[row, col] = input[col];

                }
            }
            ;

            string command = Console.ReadLine();
            int snakeFood = 0;
            bool flag = false;
            while (!flag)
            {
                mattrix[rowSnakePosition, colSnakePosition] = '.';
                if (command == "up")
                {
                    rowSnakePosition--;
                }
                else if (command == "down")
                {
                    rowSnakePosition++;
                }
                else if (command == "right")
                {
                    colSnakePosition++;
                }
                else if (command == "left")
                {
                    colSnakePosition--;
                }
                bool isValid = IsValidIndex(rowSnakePosition, colSnakePosition, size);
                if (isValid)
                {
                    if (mattrix[rowSnakePosition, colSnakePosition] == 'B')
                    {
                        mattrix[rowSnakePosition, colSnakePosition] = '.';
                        rowSnakePosition = secondPositionB[0];
                        colSnakePosition = secondPositionB[1];
                    }
                    else
                    {
                        snakeFood += MoveSnake(rowSnakePosition, colSnakePosition, mattrix, firstPositionB, secondPositionB, snakeFood);
                    }
                    mattrix[rowSnakePosition, colSnakePosition] = 'S';
                }
                else
                {
                    flag = true;

                }
                if (snakeFood == 10)
                {
                    break;
                }
               

                command = Console.ReadLine();
            }

            if (flag)
            {
                Console.WriteLine("Game over!");
            }
            if (snakeFood >= 10)
            {
                Console.WriteLine("You won! You fed the snake.");
            }
            Console.WriteLine($"Food eaten: {snakeFood}");

            for (int row = 0; row < mattrix.GetLength(0); row++)
            {
                for (int col = 0; col < mattrix.GetLength(1); col++)
                {
                    Console.Write(mattrix[row, col]);
                }
                Console.WriteLine();
            }
        }

        private static int MoveSnake(int rowSnakePosition, int colSnakePosition, char[,] mattrix, int[] firstPositionB, int[] secondPositionB, int snakeFood)
        {
            snakeFood = 0;
            if (mattrix[rowSnakePosition, colSnakePosition] == '*')
            {
                snakeFood++;
            }
            return snakeFood;
        }

        private static bool IsValidIndex(int rowSnakePosition, int colSnakePosition, int size)
        {
            return rowSnakePosition < size && rowSnakePosition >= 0 && colSnakePosition < size && colSnakePosition >= 0;
        }
    }
}