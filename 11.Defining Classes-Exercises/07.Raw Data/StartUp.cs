using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.Raw_Data
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();
            for (int i = 0; i < n; i++)
            {
                string[] dataCar = Console.ReadLine().Split(" ");
                string model = dataCar[0];
                int speed = int.Parse(dataCar[1]);
                int power = int.Parse(dataCar[2]);
                int cargo = int.Parse(dataCar[3]);
                string type = dataCar[4];
                //Tires 
                double presureOne = double.Parse(dataCar[5]);
                int tierAgeOne = int.Parse(dataCar[6]);

                double presureTwo = double.Parse(dataCar[7]);
                int tierAgeTwo = int.Parse(dataCar[8]);

                double presureThree = double.Parse(dataCar[9]);
                int tierAgeThree = int.Parse(dataCar[10]);

                double presureFour = double.Parse(dataCar[11]);
                int tierAgeFour = int.Parse(dataCar[12]);
                //EndOfInputTires
                Car car = new Car(model, speed, power, cargo, type, presureOne, tierAgeOne, presureTwo, tierAgeTwo, presureThree, tierAgeThree, presureFour, tierAgeFour);
                cars.Add(car);
            }

            string command = Console.ReadLine();

            if (command == "fragile")
            {
                HashSet<Car> result = cars.Where(x => x.Cargo.Type == "fragile" && x.Tires.Any(x => x.Preasure < 1.0)).ToHashSet();
                foreach (var item in result)
                {
                    Console.WriteLine(item);
                }

            }
            else if (command == "flamable")
            {
                HashSet<Car> result = cars.Where(x => x.Cargo.Type == command && x.Engine.Power > 250).ToHashSet();
                foreach (var item in result)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
