using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._07._Predicate_For_Names
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            List<string> names = Console.ReadLine().Split(" ").ToList();

            Predicate<string> predicate = x => x.Length <= n;

            foreach (var item in names)
            {
                if (predicate(item))
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}