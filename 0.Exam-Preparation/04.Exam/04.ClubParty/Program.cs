using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.ClubParty
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<int>> hall = new Dictionary<string, List<int>>();
            List<string> rooms = new List<string>();
            int capacity = int.Parse(Console.ReadLine());
            string[] input = Console.ReadLine().Split(" ");
            Stack<string> currentChar = new Stack<string>(input);

            while (currentChar.Count != 0)
            {
                char[] chars = currentChar.Peek().ToCharArray();

                if (Char.IsLetter(chars[0]))
                {
                    string inputHall = currentChar.Pop();

                    if (hall.Count == 0)
                    {
                        hall.Add(inputHall, new List<int>());
                    }

                    rooms.Add(inputHall);
                }
                else
                {
                    int addPeople = int.Parse(currentChar.Pop());
                    if (hall.Count != 0)
                    {
                        string currentHal = rooms[0];
                        int sum = hall[currentHal].Sum() + addPeople;

                        if (sum <= capacity)
                        {
                            hall[currentHal].Add(addPeople);
                        }
                        else
                        {
                            if (hall[currentHal].Sum() <= 60)
                            {
                                foreach (var item in hall)
                                {
                                    Console.WriteLine($"{item.Key} -> {string.Join(", ", item.Value)}");
                                }
                                hall.Remove(currentHal);
                            }

                            rooms.RemoveAt(0);

                            if (rooms.Count != 0)
                            {
                                string nextRoom = rooms[0];
                                hall.Add(nextRoom, new List<int>());
                                hall[nextRoom].Add(addPeople);
                            }
                        }
                    }
                }
            }
        }
    }
}