using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.Predicate_Party_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(" ").ToList();


            string[] command = Console.ReadLine().Split(" ");

            while (command[0] != "Party!")
            {

                Predicate<string> predicate = toPredicate(command[1], command[2]);

                if (command[0] == "Remove")
                {
                    input.RemoveAll(predicate);
                }
                else if (command[0] == "Double")
                {
                    List<string> match = input.FindAll(predicate);
                    if(match.Count>0)
                    {
                        int index = input.FindIndex(predicate);

                        input.InsertRange(index, match);
                    }
                }

                command = Console.ReadLine().Split(" ");
            }
            if (input.Count > 0)
            {
                Action<List<string>> print = names => Console.WriteLine($"{string.Join(", ", names)} are going to the party!");
                print(input);
            }
            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }
        }
        private static Predicate<string> toPredicate(string commandType, string arg)
        {
            switch (commandType)
            {
                case "StartsWith":
                    return name => name.StartsWith(arg);
                case "EndsWith":
                    return name => name.EndsWith(arg);
                case "Length":
                    return name => name.Length == int.Parse(arg);
                default:
                    throw new ArgumentException("Invalid command type: " + commandType);
            }
        }
    }
}