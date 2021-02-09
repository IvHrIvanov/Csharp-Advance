using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.GenericSwapMethodStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Box<string>> boxes = new List<Box<string>>();
            for (int i = 0; i < n; i++)
            {
                Box<string> box = new Box<string>(Console.ReadLine());
                boxes.Add(box);
            }
            int[] swap = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int firstIndex = swap[0];
            int secondIndex = swap[1];
            SwapIndex(boxes, firstIndex, secondIndex);
            foreach (Box<string> box in boxes)
            {
                Console.WriteLine(box);
            }
          
        }
        private static void SwapIndex<T>(List<Box<T>> boxes,int firstIndex, int secondIndex)
        {
            Box<T> temp = boxes[firstIndex];
            boxes[firstIndex] = boxes[secondIndex];
            boxes[secondIndex] = temp;

        }
    }
}