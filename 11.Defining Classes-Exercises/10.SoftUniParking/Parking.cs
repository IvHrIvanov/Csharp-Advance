using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoftUniParking
{
    public class Parking
    {
        private List<Car> car;
      
        public Parking(int capacity)
        {
            Capacity = capacity;
            Car = new List<Car>();
           
        }

        public int Capacity { get; set; }

        public List<Car> Car { get; set; }
        public int Count => this.Car.Count;

        public string AddCar(Car car)
        {
            StringBuilder sb = new StringBuilder();
            if (this.Car != null && Car.Any(x => x.RegistrationNumber == car.RegistrationNumber))
            {
                sb.AppendLine("Car with that registration number, already exists!");
            }
            else if (Car != null && Capacity <= Car.Count)
            {
                sb.AppendLine("Parking is full!");
            }
            else
            {
               
                Car.Add(car);
                sb.AppendLine($"Successfully added new car {car.Make} {car.RegistrationNumber}");
            }
            return sb.ToString().TrimEnd();
        }
        public void RemoveSetOfRegistrationNumber(List<string> RegistrationNumbers)
        {
            
            foreach (var item in RegistrationNumbers)
            {
                Car.Remove(Car.First(x => x.RegistrationNumber == item));
            }
        }

        public Car GetCar(string RegistrationNumber)
        {

            return this.Car.FirstOrDefault(x => x.RegistrationNumber == RegistrationNumber);
        }

        public string RemoveCar(string registrationNumber)
        {
            if (Car.Any(x => x.RegistrationNumber == registrationNumber))
            {
               
                Car.RemoveAll(x => x.RegistrationNumber == registrationNumber);
                return $"Successfully removed {registrationNumber}";

            }
            else
            {

                return "Car with that registration number, doesn't exist!";
            }

        }
    }
}
