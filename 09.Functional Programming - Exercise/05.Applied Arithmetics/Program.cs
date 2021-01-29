using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.Applied_Arithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<List<int>, string, List<int>> func = (i, s) =>
              {
                  List<int> newNumbers = new List<int>();

                  switch (s)
                  {
                      case "add":
                          newNumbers = i.Select(cur => cur + 1).ToList();
                          break;
                      case "multiply":
                          newNumbers = i.Select(cur => cur * 2).ToList();
                          break;
                      case "subtract":
                          newNumbers = i.Select(cur => cur - 1).ToList();
                          break;
                  }
                  return newNumbers;
              };

            List<int> input = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

            string command = Console.ReadLine();
            while (command != "end")
            {

                if (command == "print")
                {
                    Console.WriteLine(string.Join(" ", input));
                }
                else
                {
                    List<int> newNumber = func(input, command);
                    input = newNumber;
                }


                command = Console.ReadLine();
            }


        }
    }
}
