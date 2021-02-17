using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Scheduling
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] taskIput = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int[] threadInput = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int taskToBeKilled = int.Parse(Console.ReadLine());

            Stack<int> task = new Stack<int>(taskIput);
            Queue<int> thread = new Queue<int>(threadInput);


            while (task.Count != 0 && thread.Count != 0)
            {

                int taskValue = task.Peek();
                int threadValue = thread.Peek();
                if (taskValue == taskToBeKilled)
                {

                    break;
                }
                else if (threadValue >= taskValue)
                {
                   
                    task.Pop();
                    thread.Dequeue();
                }
                else if (threadValue < taskValue)
                {
                    thread.Dequeue();
                }



            }

            Console.WriteLine($"Thread with value {thread.Peek()} killed task {taskToBeKilled}");
            Console.WriteLine(string.Join(" ",thread));

        }
    }
}