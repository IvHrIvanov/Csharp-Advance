using System;
using System.Collections.Generic;

namespace _05._Record_Unique_Names
{
    class Program
    {
        static void Main(string[] args)
        {

            HashSet<string> names = new HashSet<string>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string currentName = Console.ReadLine();

                names.Add(currentName);


            }

            foreach (var curName in names)
            {

                Console.WriteLine(curName);
            }
        }
    }
}