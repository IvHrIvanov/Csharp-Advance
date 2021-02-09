using System;
using System.Collections.Generic;

namespace _09.GenericCountMethodDoubles
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Box<double>> boxes = new List<Box<double>>();
            for (int i = 0; i < n; i++)
            {
                Box<double> box = new Box<double>(double.Parse(Console.ReadLine()));
                boxes.Add(box);
            }
            double isLarger = double.Parse(Console.ReadLine());
            int count =IsLarger(boxes, isLarger);
            Console.WriteLine(count);
        }

        private static int IsLarger(List<Box<double>> box, double islarger)
        {
            int count = 0;

            foreach (Box<double> item in box)
            {
                if(item.Value>islarger)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
