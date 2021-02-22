using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int wave = int.Parse(Console.ReadLine());
            Stack<int> orcs = new Stack<int>();
            int[] plates = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            List<int> horaVelio = new List<int>(plates);
            bool IsFlag = false;

            for (int i = 1; i <= wave; i++)
            {
                int[] ok = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

                if (i % 3 == 0)
                {
                    int add = int.Parse(Console.ReadLine());

                    horaVelio.Add(add);
                }
                orcs = new Stack<int>(ok);


                while (orcs.Count != 0 && horaVelio.Count != 0)
                {
                    int currentOne = horaVelio[0];
                    int currentTWo = orcs.Peek();
                    if (currentOne < currentTWo)
                    {
                        int namalqne = orcs.Pop();
                        if (namalqne - currentOne <= 0)
                        {
                            orcs.Pop();
                        }
                        else
                        {
                            orcs.Push(namalqne - currentOne);
                        }
                        horaVelio.RemoveAt(0);
                    }
                    else if (currentOne > currentTWo)
                    {

                        horaVelio[0] -= currentTWo;
                        orcs.Pop();
                    }
                    else if (currentTWo == currentOne)
                    {
                        horaVelio.RemoveAt(0);
                        orcs.Pop();

                    }

                }

                if (horaVelio.Count == 0)
                {
                    IsFlag = true;
                    break;
                }
            }
            if (IsFlag)
            {
                Console.WriteLine("The orcs successfully destroyed the Gondor's defense.");
            }
            else
            {
                Console.WriteLine("The people successfully repulsed the orc's attack.");
            }
            if (orcs.Count > 0)
            {
                Console.WriteLine($"Orcs left: {string.Join(", ", orcs)}");
            }
            else if (horaVelio.Count > 0)
            {
                Console.WriteLine($"Plates left: {string.Join(", ", horaVelio)}");
            }

        }
    }
}