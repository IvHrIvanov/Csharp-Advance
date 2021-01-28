using System;
using System.IO;

namespace _02.LineNumber
{
    class Program
    {
        static void Main(string[] args)
        {

            string filePath = "../../../text.txt";
            using (StreamReader reader = new StreamReader(filePath))
            {

                using (StreamWriter writer = new StreamWriter("output.txt"))
                {

                    string line = reader.ReadLine();
                    int count = 0;
                    while (line != null)
                    {
                        int countLeters = 0;
                        int countPunctuation = 0;

                        foreach (var item in line)
                        {
                            if(Char.IsLetter(item))
                            {
                                countLeters++;
                            }
                            else if (Char.IsPunctuation(item))
                            {
                                countPunctuation++;
                            }

                        }
                        count++;
                        writer.WriteLine($"Line {count}: {line} ({countLeters})({countPunctuation})");
                        Console.WriteLine($"Line {count}: {line} ({countLeters})({countPunctuation})");
                        line = reader.ReadLine();
                    }


                }
            }
        }
    }
}