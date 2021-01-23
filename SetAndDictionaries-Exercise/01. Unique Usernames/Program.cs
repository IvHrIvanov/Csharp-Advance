using System;
using System.Collections.Generic;

namespace _01._Unique_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> usernames = new HashSet<string>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                if (!usernames.Contains(input))
                {
                    usernames.Add(input);
                }
            }

            foreach (var item in usernames)
            {
                Console.WriteLine(item);
            }

        }
    }
}
