using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Set_of_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> n = new HashSet<string>();
            HashSet<string> m = new HashSet<string>();
            int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            

            for (int i = 0; i < input[0]; i++)
            {
                int addNum = int.Parse(Console.ReadLine());

                n.Add(addNum.ToString());
            }
            for (int i = 0; i < input[1]; i++)
            {
                int addNum = int.Parse(Console.ReadLine());
                m.Add(addNum.ToString());

            }

            foreach (var item in n)
            {

                string current = item;
                if(m.Contains(item))
                {
                    Console.Write($"{item}" + " ");
                }

            }

        }
    }
}
