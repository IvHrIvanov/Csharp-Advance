using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Fashion_Boutique
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] input = Console.ReadLine().Split(" ")
                                            .Select(int.Parse)
                                            .ToArray();

            int capacity = int.Parse(Console.ReadLine());

            Stack<int> queue = new Stack<int>(input);
            int rack = 1;
            int sumSize = 0;

            while (queue.Count > 0)
            {

                int current = queue.Pop();
                sumSize += current;
                if (sumSize == capacity)
                {
                    if (queue.Count > 0)
                    {
                        rack++;
                    }
                    sumSize = 0;
                }
                else if (sumSize > capacity)
                {
                    rack++;
                    sumSize = 0;
                    sumSize += current;
                }
            }

            Console.WriteLine(rack);
        }
    }
}