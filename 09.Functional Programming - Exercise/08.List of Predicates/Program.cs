using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.List_of_Predicates
{
    class Programa
    {
        static void Main(string[] args)
        {
            Func<List<int>, int, List<int>> func = (list, n) =>
              {
                  List<int> devidetNumbers = new List<int>();

                  for (int i = 1; i <= n; i++)
                  {
                      if (list.All(x => i % x == 0))
                      {
                          devidetNumbers.Add(i);
                      }
                  }
                  return devidetNumbers;
              };

            int n = int.Parse(Console.ReadLine());
            List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            List<int> outputNumbers = func(numbers, n);

            Action<List<int>> print = numbers => Console.WriteLine(string.Join(" ", numbers));
            print(outputNumbers);

        }
    }
}