using System;
using System.Collections.Generic;

namespace _06.Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> wardobe = new Dictionary<string, Dictionary<string, int>>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] clothes = Console.ReadLine().Split(new[] { " -> ", "," }, StringSplitOptions.RemoveEmptyEntries);
                string color = clothes[0];
                for (int j = 1; j < clothes.Length; j++)
                {
                    string cloth = clothes[j];

                    if (!wardobe.ContainsKey(color))
                    {
                        wardobe.Add(color, new Dictionary<string, int>());

                    }
                    if (!wardobe[color].ContainsKey(cloth))
                    {
                        wardobe[color].Add(cloth, 0);
                    }
                    wardobe[color][cloth]++;

                }

            }

            string[] pickCloth = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string findCOlor = pickCloth[0];
            string findDress = pickCloth[1];
            foreach (var color in wardobe)
            {

                string currentColor = color.Key;
                Console.WriteLine($"{currentColor} clothes:");
                
                    foreach (var item in color.Value)
                    {
                        string currentDress = item.Key;
                        if (currentColor == findCOlor && currentDress == findDress)
                        {
                            Console.WriteLine($"* {currentDress} - {item.Value} (found!)");
                        }
                        else
                        {
                            Console.WriteLine($"* {currentDress} - {item.Value}");
                        }
                    }

             
            }
        }
    }
}