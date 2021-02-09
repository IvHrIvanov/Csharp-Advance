using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.GenericCountMethodStrings
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
            string input = Console.ReadLine();
            Box<string> boxComp = new Box<string>(input);

           int count = GetGreater(boxes, boxComp);
            Console.WriteLine(count);

        }
        private static int GetGreater<T>(List<Box<T>> boxes,Box<T> box)
            where T: IComparable
        {
            int count = 0;
            foreach (Box<T> item in boxes)
            {
                if(item.Value.CompareTo(box.Value)>0)
                {
                    count++;
                }
            }

            return count;
        }

    }
}