using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.Count_Symbols
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<char, int> lettersCount = new SortedDictionary<char, int>();
            string text = Console.ReadLine();

            for (int i = 0; i < text.Length; i++)
            {
               char curr = text[i];
                if (!lettersCount.ContainsKey(curr))
                {
                    lettersCount.Add(curr, 1);
                }
                else
                {
                    lettersCount[curr]++;
                }
            }

            foreach (var item in lettersCount)
            {
                Console.WriteLine($"{item.Key}: {item.Value} time/s");

            }
        }
    }
}