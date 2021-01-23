using System;
using System.Collections.Generic;

namespace _01.Count_Same_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            Dictionary<string, int> save = new Dictionary<string, int>();
            
            for (int i = 0; i < input.Length; i++)
            {
                string current = input[i];

                if(!save.ContainsKey(current))
                {
                    save.Add(current, 0);
                    save[current] += 1;
                }
                else
                {
                    save[current]++;
                }


            }
            foreach (var item in save)
            {
                Console.WriteLine($"{item.Key} - {item.Value} times");
            }
        }
    }
}
