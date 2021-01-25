using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.The_V_Logger
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, Dictionary<string, SortedSet<string>>> vLogger = new Dictionary<string, Dictionary<string, SortedSet<string>>>();

            string[] input = Console.ReadLine().Split(" ");

            while (input[0] != "Statistics")
            {

                string firstVloger = input[0];
                string command = input[1];


                if (command == "joined")
                {
                    if (!vLogger.ContainsKey(firstVloger))
                    {
                        vLogger.Add(firstVloger, new Dictionary<string, SortedSet<string>>());
                        vLogger[firstVloger].Add("following", new SortedSet<string>());
                        vLogger[firstVloger].Add("followers", new SortedSet<string>());
                    }

                }
                else if (command == "followed")
                {
                    string secondVloger = input[2];
                    if (vLogger.ContainsKey(firstVloger) && vLogger.ContainsKey(secondVloger))
                    {
                        if (firstVloger != secondVloger)
                        {
                            if (!vLogger[secondVloger]["followers"].Contains(firstVloger))
                            {
                                vLogger[secondVloger]["followers"].Add(firstVloger);
                                vLogger[firstVloger]["following"].Add(secondVloger);
                            }
                        }
                    }
                }




                input = Console.ReadLine().Split(" ");
            }

            vLogger = vLogger.OrderByDescending(k => k.Value["followers"].Count).ThenBy(kvp => kvp.Value["following"].Count).ToDictionary(k => k.Key, v => v.Value);
            Console.WriteLine($"The V-Logger has a total of {vLogger.Keys.Count} vloggers in its logs.");
            int count = 1;
            foreach (var vlog in vLogger)
            {
                int followers = vlog.Value["followers"].Count;
                int following = vlog.Value["following"].Count;
                Console.WriteLine($"{count}. {vlog.Key} : {followers} followers, {following} following");
                if (count == 1)
                {
                    foreach (var item in vlog.Value["followers"])
                    {
                        Console.WriteLine($"* {item}");

                    }
                }

                count++;
            }

        }
    }
}