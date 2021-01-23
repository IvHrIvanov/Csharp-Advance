using System;
using System.Collections.Generic;
using System.Linq;
namespace _02._Average_Student_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<decimal>> students = new Dictionary<string, List<decimal>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string studentName = input[0];
                decimal grade = decimal.Parse(input[1]);

                if (!students.ContainsKey(studentName))
                {
                    students.Add(studentName, new List<decimal>());
                    students[studentName].Add(grade);
                }
                else
                {
                    students[studentName].Add(grade);
                }


            }
            foreach (var item in students)
            {
                Console.Write($"{item.Key} -> ");
                decimal grade = 0;      
                foreach (var grades in item.Value)
                {
                    grade += grades;
                    Console.Write($"{grades:f2}" + " ");
                }
                Console.WriteLine($"(avg: {grade/item.Value.Count:f2})");
                
            }
        }
    }
}
