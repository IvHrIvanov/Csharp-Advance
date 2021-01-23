using System;
using System.Collections.Generic;

namespace _04._Even_Times
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, int> even = new Dictionary<int, int>();
            int n = int.Parse(Console.ReadLine());
            string output = string.Empty;
            for (int i = 0; i < n; i++)
            {
                int input = int.Parse(Console.ReadLine());

                if (!even.ContainsKey(input))
                {
                    even.Add(input, 1);
                }
                else
                {
                    even[input]++;
                }
            }

            foreach (var item in even)
            {

                if (item.Value % 2 == 0)
                {
                    Console.WriteLine(item.Key);
                    break;
                }

            }

        }
    }
}
