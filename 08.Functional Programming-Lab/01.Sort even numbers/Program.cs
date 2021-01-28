using System;
using System.Linq;

namespace _01.Sort_even_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(", ")
                 .Select(int.Parse)
                 .Where(x => x % 2 == 0)
                 .OrderBy(x=>x)
                 .ToArray();

            Console.WriteLine(string.Join(", ", input));

        }
    }
}