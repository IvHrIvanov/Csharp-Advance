using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, Dictionary<string, int>> persons = new SortedDictionary<string, Dictionary<string, int>>();
            Dictionary<string, string> data = new Dictionary<string, string>();

            string[] input = Console.ReadLine().Split(":");

            while (input[0] != "end of contests")
            {
                string contest = input[0];
                string password = input[1];

                data.Add(contest, password);

                input = Console.ReadLine().Split(":");
            }

            input = Console.ReadLine().Split("=>");

            while (input[0] != "end of submissions")
            {
                string contest = input[0];
                string pass = input[1];
                string user = input[2];
                int points = int.Parse(input[3]);

                if (data.ContainsKey(contest) && data[contest].Contains(pass))
                {
                    if (!persons.ContainsKey(user))
                    {
                        persons.Add(user, new Dictionary<string, int>());
                        persons[user].Add(contest, 0);
                    }
                    if (!persons[user].ContainsKey(contest))
                    {
                        persons[user].Add(contest, points);
                    }
                    else
                    {
                        int oldPoints = persons[user][contest];
                        if(oldPoints<points)
                        {
                            persons[user][contest] = points;
                        }
                    }
                    
                }

                input = Console.ReadLine().Split("=>");
            }

            KeyValuePair<string,Dictionary<string, int>> bestCandidate = persons.OrderByDescending(kvp => kvp.Value.Values.Sum()).First();
            int totalPoints = bestCandidate.Value.Values.Sum();
            Console.WriteLine($"Best candidate is {bestCandidate.Key} with total {totalPoints} points.");
            Console.WriteLine("Ranking:");

            foreach (var user in persons)
            {
                Console.WriteLine(user.Key);
                foreach (var item in user.Value.OrderByDescending(v=>v.Value))
                {
                    Console.WriteLine($"#  {item.Key} -> {item.Value}");
                }

            }
        }
    }
}