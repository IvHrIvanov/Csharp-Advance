using System;
using System.Text;

namespace _02._Bee
{
    class Program
    {
        static void Main(string[] args)
        {

            int size = int.Parse(Console.ReadLine());
            char[,] mattrix = new char[size, size];
            int rowBee = 0;
            int colBee = 0;
            int bonusRow = 0;
            int bonusCol = 0;
            for (int i = 0; i < size; i++)
            {
                string input = Console.ReadLine();
                for (int j = 0; j < size; j++)
                {
                    if (input[j] == 'B')
                    {
                        rowBee = i;
                        colBee = j;
                    }
                    if (input[j] == 'O')
                    {
                        bonusRow = i;
                        bonusCol = j;
                    }
                    mattrix[i, j] = input[j];

                }
            }
            int polinationed = 0;
            string command = Console.ReadLine();
            bool flag = true;
            bool lost = false;
            while (command != "End")
            {
                mattrix[rowBee, colBee] = '.';
                if (command == "up")
                {
                    rowBee--;
                }
                else if (command == "down")
                {
                    rowBee++;
                }
                else if (command == "right")
                {
                    colBee++;
                }
                else if (command == "left")
                {
                    colBee--;
                }
                flag = isValid(rowBee, colBee, size);
                if (flag)
                {
                    char symbol = mattrix[rowBee, colBee];

                    if (symbol == 'f')
                    {
                        polinationed++;
                    }
                    else if (symbol == 'O')
                    {
                        mattrix[rowBee, colBee] = '.';
                        if(command=="up")
                        {
                            rowBee--;
                        }
                        else if( command=="left")
                        {
                            colBee--;
                        }
                        else if (command == "right")
                        {
                            colBee++;

                        }
                        else if (command == "down")
                        {
                            rowBee++;

                        }
                        symbol = mattrix[rowBee, colBee];
                        if (symbol == 'f')
                        {

                            polinationed++;
                        }
                    }

                    mattrix[rowBee, colBee] = 'B';
                }
                else
                {
                    lost = true;
                    break;
                }
                command = Console.ReadLine();
            }
            StringBuilder sb = new StringBuilder();

            if (lost)
            {
                sb.AppendLine("The bee got lost!");
            }
            if (5 <= polinationed)
            {
                sb.AppendLine($"Great job, the bee managed to pollinate {polinationed} flowers!");
            }
            else
            {
                int needed = 5 - polinationed;
                sb.AppendLine($"The bee couldn't pollinate the flowers, she needed {needed} flowers more");
            }
            Console.Write(sb);
            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    Console.Write(mattrix[row, col]);
                }
                Console.WriteLine();
            }
        }

        private static bool isValid(int rowBee, int colBee, int size)
        {
            return rowBee < size && colBee < size && colBee >= 0 && rowBee >= 0;
        }
    }
}