using System;
using System.Linq;

namespace _02.Sum_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int lenght = 0;
            int[] input = Console.ReadLine().Split(", ")
                                            .Select(int.Parse)
                                            .Select(x => count += x)
                                            .Select(x => lenght++)
                                            .ToArray();
            Console.WriteLine(lenght);
            Console.WriteLine(count);
        }
    }
}