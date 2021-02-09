using System;

namespace _10.Threeuple
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ");
            string fullName = $"{input[0]} {input[1]}";
            Threeuple<string, string, string> firstUple = new Threeuple<string, string, string>(fullName, input[2], input[3]);

            input = Console.ReadLine().Split(" ");

            string choice = IsDrunk(input[2]);
            Threeuple<string, int, string> secondUple = new Threeuple<string, int, string>(input[0], int.Parse(input[1]), choice);

            input = Console.ReadLine().Split(" ");
            Threeuple<string, double, string> thirdUple = new Threeuple<string, double, string>(input[0], double.Parse(input[1]), input[2]);

            Console.WriteLine(firstUple);
            Console.WriteLine(secondUple);
            Console.WriteLine(thirdUple);


        }

        private static string IsDrunk(string choice)
        {
            if (choice == "drunk")
            {
                return "True";
            }
            return "False";

        }
    }
}
