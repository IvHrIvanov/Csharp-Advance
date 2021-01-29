using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Find_Evens_or_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int start = input[0];
            int end = input[1];

            string evenOrODd = Console.ReadLine();

            Func<int, int, List<int>> generate = (s, e) =>
           {
               List<int> nums = new List<int>();

               for (int i = start; i <= end; i++)
               {
                   nums.Add(i);
               }
               return nums;
           };
            List<int> newNumber = generate(start, end);
            Predicate<int> predicate = n => true;
            if (evenOrODd == "even")
            {
                predicate = e => e % 2 == 0;
            }
            else if (evenOrODd == "odd")
            {
                predicate = o => o % 2 != 0;
            }
            Console.WriteLine(string.Join(" ",MyWhere(newNumber, predicate)));
        }
        static List<int> MyWhere(List<int> numbers, Predicate<int> predicate)
        {
            List<int> newNumbers = new List<int>();

            foreach (var num in numbers)
            {
                if (predicate(num))
                {
                    newNumbers.Add(num);
                }
            }
            return newNumbers;

        }
    }
}