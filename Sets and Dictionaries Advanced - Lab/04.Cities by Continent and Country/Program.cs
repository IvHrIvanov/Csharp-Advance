using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Cities_by_Continent_and_Country
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, List<string>>> country = new Dictionary<string, Dictionary<string, List<string>>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ");

                string continent = input[0];
                string countries = input[1];
                string cities = input[2];

                if(!country.ContainsKey(continent))
                {
                    country.Add(continent, new Dictionary<string, List<string>>());
                   
                }
               if(!country[continent].ContainsKey(countries))
                {
                    country[continent].Add(countries, new List<string>());
                }
                country[continent][countries].Add(cities);

            }
            foreach (var item in country)
            {
                Console.WriteLine($"{item.Key}:");
                foreach (var current in item.Value)
                {
                    Console.WriteLine($"  {current.Key} -> {string.Join(", ",current.Value)} ");
                }

            }
        }
    }
}