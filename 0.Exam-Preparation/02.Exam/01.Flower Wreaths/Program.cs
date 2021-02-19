using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _01._Flower_Wreaths
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] liliesAdd = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int[] rosesAdd = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            Stack<int> lilies = new Stack<int>(liliesAdd);
            Queue<int> roses = new Queue<int>(rosesAdd);

            int wreath = 0;
            int n = 0;
            while (lilies.Count != 0 && roses.Count != 0)
            {
                int roseValue = roses.Peek();
                int liliesValue = lilies.Peek();

                int sum = roseValue + liliesValue;

                if (sum == 15)
                {
                    roses.Dequeue();
                    lilies.Pop();
                    wreath++;
                }
                else if (sum > 15)
                {
                    int decreaseValue = lilies.Pop();
                    lilies.Push(decreaseValue - 2);
                }
                else
                {
                    n += sum;
                    roses.Dequeue();
                    lilies.Pop();
                }

            }

            if (wreath >= 5)
            {
                Console.WriteLine($"You made it, you are going to the competition with {wreath} wreaths!" );
            }
            else
            {
                int needet = n/15+wreath;
                Console.WriteLine($"You didn't make it, you need {5-needet} wreaths more!");
            }

        }
    }
}
