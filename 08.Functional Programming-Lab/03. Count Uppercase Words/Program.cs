using System;
using System.Linq;

namespace _03._Count_Uppercase_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, bool> firstLetter = text => Char.IsUpper(text[0]);
                  string[] input = Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries);

            input = input.Where(firstLetter).ToArray();
            Console.WriteLine(string.Join(Environment.NewLine,input));

        }
    }
}