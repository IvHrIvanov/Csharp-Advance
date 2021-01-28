using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _03._Word_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string restulPath = Path.Combine("../../../restult.txt");
            string[] words = File.ReadAllLines("../../../words.txt");
            Dictionary<string,int> wordCount = new Dictionary<string, int>();

            foreach (var item in words)
            {
                wordCount.Add(item.ToLower(), 0);
            }
            string text = File.ReadAllText("../../../text.txt").ToLower();
            string[] textWord = text.Split(new string[] { " ", "!", "?", "-", ".", "," , Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string curWord in textWord)
            {
                if(wordCount.ContainsKey(curWord.ToLower()))
                {
                    wordCount[curWord]++;
                }

            }
            Dictionary<string, int> sorted = wordCount.OrderByDescending(k => k.Value).ToDictionary(k => k.Key, v => v.Value);

            List<string> lines = sorted.Select(kv => $"{kv.Key} - {kv.Value}").ToList();
            File.WriteAllLines(restulPath, lines);
        }
    }
}