using System;
using System.Collections.Generic;

namespace _07._SoftUni_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> quests = new HashSet<string>();
            string input = Console.ReadLine();

            while (input != "PARTY")
            {
                if (!quests.Contains(input) && input.Length == 8)
                {
                    quests.Add(input);
                }
                input = Console.ReadLine();
            }

            input = Console.ReadLine();
            while (input != "END")
            {
                if (quests.Contains(input))
                {
                    quests.Remove(input);
                }
                input = Console.ReadLine();
            }

            Console.WriteLine(quests.Count);

            foreach (var item in quests)
            {
                char[] ch = item.ToCharArray();
                if (Char.IsDigit(ch[0]))
                {
                    Console.WriteLine(item);
                }

            }
            foreach (var item in quests)
            {
                char[] ch = item.ToCharArray();
                if (Char.IsLetter(ch[0]))
                {
                    Console.WriteLine(item);
                }

            }
        }
    }
}