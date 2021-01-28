using System;
using System.Collections.Generic;

namespace _06.Songs_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] songs = Console.ReadLine().Split(", ");
            Queue<string> queue = new Queue<string>(songs);

            string command = Console.ReadLine();
            while (queue.Count > 0)
            {
           
                if (command == "Play")
                {
                    queue.Dequeue();
                }
                else if (command.Contains("Add"))
                {                                                 
                    string songAdd = command.Substring(4, command.Length-4);
                    if (queue.Contains(songAdd))
                    {
                       
                        Console.WriteLine($"{songAdd} is already contained!");
                    }
                    else
                    {
                        queue.Enqueue(songAdd);
                    }
                }
                else if (command == "Show")
                {

                    Console.WriteLine(string.Join(", ", queue));
                }

                command = Console.ReadLine();
            }
            Console.WriteLine("No more songs!");
        }
    }
}