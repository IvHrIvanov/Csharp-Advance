using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
           int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                
                string[] input = Console.ReadLine().Split(" ");
                string model = input[0];
                double fuelAmount = double.Parse(input[1]);
                double fuelConsumptionFor1km = double.Parse(input[2]);
                Car currentCar = new Car(model, fuelAmount, fuelConsumptionFor1km);
                cars.Add(currentCar);
            }

            string[] command = Console.ReadLine().Split(" ");

            while (command[0]!="End")
            {
                string curCommand = command[0];
                string carModel = command[1];
                int distance = int.Parse(command[2]);

                Car car = cars.FirstOrDefault(c=>c.Model==carModel);
              
                if(!car.Drive(distance))
                {
                    Console.WriteLine("Insufficient fuel for the drive");
                }
                
                command = Console.ReadLine().Split(" ");
            }

            foreach (Car currCar in cars)
            {

                Console.WriteLine($"{currCar.Model} {currCar.FuelAmount:f2} {currCar.TravelledDistance}");

            }
        }
    }
}