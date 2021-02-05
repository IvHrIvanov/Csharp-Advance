using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {


        static void Main(string[] args)
        {
            HashSet<Engine> engines = new HashSet<Engine>();
            List<Car> cars = new List<Car>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string model = input[0];
                int power = int.Parse(input[1]);

                Engine engine = null;


                if (input.Length == 4)
                {
                    int displacement = int.Parse(input[2]);
                    string efficiency = input[3];
                    engine = new Engine(model, power, displacement, efficiency);

                }
                else if (input.Length == 3)
                {
                    int displacemtn;

                    bool isDisplacment = int.TryParse(input[2], out displacemtn);
                    if (isDisplacment)
                    {
                        engine = new Engine(model, power, displacemtn);

                    }
                    else
                    {
                        engine = new Engine(model, power, input[2]);
                    }
                }
                else if (input.Length == 2)
                {
                    engine = new Engine(model, power);
                }

                engines.Add(engine);
            }

            int m = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string model = input[0];
                Engine engin = engines.First(x => x.Model == input[1]);
              
                Car car = null;

                if (input.Length == 2)
                {
                    car = new Car(model, engin);
                }
                else if (input.Length == 3)
                {
                    double weight;
                    bool isvalidWeight = double.TryParse(input[2], out weight);
                    if(isvalidWeight)
                    {
                        car = new Car(model, engin, weight);
                    }
                    else
                    {
                        car = new Car(model, engin, input[2]);
                    }

                }
                else if (input.Length==4)
                {
                    int weight = int.Parse(input[2]);
                    string color = input[3];
                    car = new Car(model, engin, weight, color);
                }

                if(car!=null)
                {
                    cars.Add(car);
                }

            }


            foreach (Car item in cars)
            {
                Console.WriteLine(item);
            }

        }
    }
}
