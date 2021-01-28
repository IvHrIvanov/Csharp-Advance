using System;
using System.Collections.Generic;

namespace _05.Filter_by_Age
{
    class Program
    {
        class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }

        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Person[] people = new Person[n];

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(", ");
                people[i] = new Person();
                people[i].Name = input[0];
                people[i].Age = int.Parse(input[1]);
            }

            string olderOrYoung = Console.ReadLine();
            int filterAge = int.Parse(Console.ReadLine());
            Func<Person, bool> condition = GetAgeCondition(olderOrYoung, filterAge);
            Func<Person, string> formater = GetFormatter(Console.ReadLine());
            PrintPeople(people, condition,formater);




        }
        static Func<Person, string> GetFormatter(string format)
        {
            switch(format)
            {
                case "name":
                    return p => $"{p.Name}";
                case "age":
                    return p => $"{p.Age}";
                case "name age":
                    return p => $"{p.Name} - {p.Age}";
                default:
                    return null;
            }
        }
        static Func<Person, bool> GetAgeCondition(string filter, int filterAge)
        {
            switch (filter)
            {
                case "younger": return p => p.Age < filterAge;
                case "older": return p => p.Age >= filterAge;
                case "youngAdul": return p => false;
                default:
                    return null;

            }
        }
        static void PrintPeople(Person[] people, Func<Person, bool> condition,Func<Person,string> forrmater)
        {
            foreach (var person in people)
            {
                if (condition(person))
                {
                    Console.WriteLine(forrmater(person));
                }

            }
        }

    }
}
