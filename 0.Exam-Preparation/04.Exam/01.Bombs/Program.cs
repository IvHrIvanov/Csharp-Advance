using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01.Bombs
{
    class Program
    {
        static void Main(string[] args)
        {
           // Dictionary<string, int> bombs = new Dictionary<string, int>();
            int[] inputEfect = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int[] inputCasing = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            Queue<int> efectBomb = new Queue<int>(inputEfect);
            Stack<int> casingBomb = new Stack<int>(inputCasing);

            int daturaBombs = 0;
            int cherryBombs = 0;
            int smokeDecoyBombs = 0;
            bool flag = false;
            while (efectBomb.Count != 0 && casingBomb.Count != 0)
            {
                int efect = efectBomb.Peek();
                int casing = casingBomb.Peek();
                int sum = efect + casing;

                if (sum == 40)
                {
                    daturaBombs++;
                    RemoveBomb(casingBomb, efectBomb);
                }
                else if (sum == 60)
                {
                    cherryBombs++;
                    RemoveBomb(casingBomb, efectBomb);
                }
                else if (sum == 120)
                {
                    smokeDecoyBombs++;
                    RemoveBomb(casingBomb, efectBomb);
                }
                else
                {
                    int decrese = casingBomb.Pop() - 5;
                    casingBomb.Push(decrese);
                }
                if (daturaBombs == 3 && cherryBombs == 3 && smokeDecoyBombs == 3)
                {
                    flag = true;
                    break;
                }
            }
            StringBuilder sb = new StringBuilder();
            if (flag)
            {
                sb.AppendLine("Bene! You have successfully filled the bomb pouch!");
            }
            else
            {
                sb.AppendLine("You don't have enough materials to fill the bomb pouch.");
            }
            if (efectBomb.Count == 0)
            {
                sb.AppendLine("Bomb Effects: empty");
            }
            else
            {
                sb.AppendLine($"Bomb Effects: {string.Join(", ",efectBomb)}" );
            }
            if (casingBomb.Count == 0)
            {
                sb.AppendLine("Bomb Casings: empty");
            }
            else
            {
                sb.AppendLine($"Bomb Effects: {string.Join(", ", casingBomb)}");
            }
            sb.AppendLine($"Cherry Bombs: {cherryBombs}");
            sb.AppendLine($"Datura  Bombs: {daturaBombs}");
            sb.AppendLine($"Smoke Decoy Bombs: {smokeDecoyBombs}");

            Console.WriteLine(sb);
        }

        private static void RemoveBomb(Stack<int> casingBomb, Queue<int> efectBomb)
        {
            casingBomb.Pop();
            efectBomb.Dequeue();
        }
    }
}
