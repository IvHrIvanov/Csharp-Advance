using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Custom_Min_Function
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<List<int>, int> minNUmber = num =>
             {
                 int minNumber = int.MaxValue;
                 foreach (var item in num)
                 {
                     if (item < minNumber)
                     {
                         minNumber = item;
                     }

                 }
                 return minNumber;

             };
            List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
          
            Console.WriteLine(minNUmber(numbers));

        }
    }
}