using System;

namespace CarManufacturer
{
   public class StartUp
    {
        static void Main(string[] args)
        {

            Engine v8 = new Engine(306, 5000);
            Tire[] tires = new Tire[]
            {
                new Tire(2019,2.5),
            new Tire(2018, 2.4),
            new Tire(2017, 2.2),
            new Tire(2020, 2.1),
            };

            Car mercedes = new Car("Mercedes", "CLS", 2005, -20,5000, v8, tires);
            Console.WriteLine(mercedes.Engine.HorsePower);

            foreach (var tire in mercedes.Tires)
            {

                Console.WriteLine($"{tire.Year} - {tire.Pressure}");

            }


        }
    }
}
