using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Car
    {
        public Car(string model, double fuelAmount, double fuelConsumptFor1km)
        {
            this.Model = model;
            this.FuelAmount = fuelAmount;
            this.FuelConsumptionPerKilometer = fuelConsumptFor1km;
        }

        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelConsumptionPerKilometer { get; set; }
        public double TravelledDistance { get; set; } = 0;

        public bool Drive(double distance)
        {

            double needFuel = distance * FuelConsumptionPerKilometer;
            if (needFuel > FuelAmount)
            {
                return false;
            }

            FuelAmount -= needFuel;
            TravelledDistance += distance;

            return true;
        }
    }
}
