using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUniParking
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var car = new Car("Skoda", "Fabia", 65, "CC1856BG");
            var car2 = new Car("Audi", "A3", 110, "EB8787MN");

            Console.WriteLine(car.ToString());

            var parking = new Parking(5);
            Console.WriteLine(parking.AddCar(car));
            
            Console.WriteLine(parking.AddCar(car));
            //Car with that registration number, already exists!
            Console.WriteLine(parking.AddCar(car2));

            Console.WriteLine(parking.GetCar("EB8787MN").ToString());
            //Successfully added new car Audi EB8787MN
            Console.WriteLine(parking.RemoveCar("EB8787MN"));
       
            Console.WriteLine(parking.Count);
        }

    
    }
}
