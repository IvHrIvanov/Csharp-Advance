using System;
using System.Collections.Generic;

namespace _06.Parking_Lot
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> cars = new HashSet<string>();

            string[] input = Console.ReadLine().Split(", ");

            while (input[0] != "END")
            {
                string command = input[0];
                string currCar = input[1];
                if (command == "IN")
                {
                    cars.Add(currCar);
                }
                else if (command == "OUT")
                {
                    cars.Remove(currCar);

                }


                input = Console.ReadLine().Split(", ");
            }
            if (cars.Count == 0)
            {
                Console.WriteLine("Parking Lot is Empty");
            }
            else
            {

                foreach (var item in cars)
                {
                    Console.WriteLine(item);

                }
            }

        }
    }
}