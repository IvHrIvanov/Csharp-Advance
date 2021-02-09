using System;
using System.Collections.Generic;

namespace _10.Tuple
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ");
            MyTuple<string, string> firstTuple = new MyTuple<string, string>(input[0] + " " + input[1], input[2]);
            input = Console.ReadLine().Split(" ");
            MyTuple<string, int> secondTuple = new MyTuple<string, int>(input[0], int.Parse(input[1]));
            input = Console.ReadLine().Split(" ");
            MyTuple<int, double> thirdTuple = new MyTuple<int, double>(int.Parse(input[0]), double.Parse(input[1]));


            Console.WriteLine(firstTuple);
            Console.WriteLine(secondTuple);
            Console.WriteLine(thirdTuple);

        }
    }
}