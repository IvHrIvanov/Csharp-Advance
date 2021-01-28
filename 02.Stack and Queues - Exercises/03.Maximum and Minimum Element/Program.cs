using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Maximum_and_Minimum_Element
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            Stack<int> queue = new Stack<int>();
            for (int i = 0; i < n; i++)
            {
                int[] command = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                if (command[0] == 1)
                {
                    int pushNumber = command[1];
                    queue.Push(pushNumber);
                }
                else if (command[0] == 2 && queue.Count > 0)
                { 
                    queue.Pop();
                }
                else if (command[0] == 3 && queue.Count > 0)
                {
                    Console.WriteLine(queue.Max());
                }
                else if (command[0] == 4 && queue.Count > 0)
                {
                    Console.WriteLine(queue.Min());
                }

            }
            Console.WriteLine(string.Join(", ", queue));
        }
    }
}
