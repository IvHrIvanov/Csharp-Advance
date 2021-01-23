using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Periodic_Table
{
    class Program
    {
        static void Main(string[] args)
        {

            HashSet<string> unique = new HashSet<string>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {

                string[] compounds = Console.ReadLine().Split(" ");

                foreach (var item in compounds)
                {
                    unique.Add(item);
                }


            }
          
            unique= unique.OrderBy(x => x).ToHashSet();
            Console.WriteLine(string.Join(" ", unique));
        }
    }
}