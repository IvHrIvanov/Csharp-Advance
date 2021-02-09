using System;
using System.Collections.Generic;
using System.Linq;

namespace _04_GenericSwapMethodIntegers
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            List<Box<int>> boxes = new List<Box<int>>();
            for (int i = 0; i < n; i++)
            {
                Box<int> box = new Box<int>(int.Parse(Console.ReadLine()));
                boxes.Add(box);
            }
            int[] swapIndex = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            SwapIndex(boxes, swapIndex[0], swapIndex[1]);

            foreach (Box<int> current in boxes)
            {
                Console.WriteLine(current);
            }
        }

        private static void SwapIndex<T>(List<Box<T>> boxes, int firstIndex, int secondIndex)
        {

            Box<T> temp = boxes[firstIndex];
            boxes[firstIndex] = boxes[secondIndex];
            boxes[secondIndex] = temp;


        }

    }
}