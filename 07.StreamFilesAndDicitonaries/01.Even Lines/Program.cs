using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace _01.Even_Lines
{
    class Program
    {
        static void Main(string[] args)
        {

            string filePath = "../../../text.txt";
            string pattern = @"[-,.!?]";
            using (StreamReader reader = new StreamReader(filePath))
            {
                using (StreamWriter writer = new StreamWriter("output.txt"))
                {

                    string line = reader.ReadLine();
                    int count = 0;

                    while (line != null)
                    {
                        List<string> chars = new List<string>();

                        if (count % 2 == 0)
                        {
                            string replaceIt = Regex.Replace(line, pattern, "@");
                            string[] word = replaceIt.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);

                            Console.WriteLine(string.Join(" ",word.Reverse()));
                            writer.WriteLine(string.Join(" ", word.Reverse()));
                        }
                        count++;
                        line = reader.ReadLine();
                    }
                }
            }
        }
    }
} 