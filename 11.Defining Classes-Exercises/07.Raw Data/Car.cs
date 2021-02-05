using System;
using System.Collections.Generic;
using System.Text;

namespace _07.Raw_Data
{
    public class Car
    {
        private string model;
        private Engine engine;
        private Cargo cargo;
        private List<Tires> tires;

        public Car(string model,int engineSpeed, int enginePower,int cargoWeight, string cargoType, double tire1Pressure,int tire1Age, double tire2Pressure,int tire2Age, double tire3Pressure,int tire3Age, double tire4Pressure,int tire4Age)
        {
            Model = model;
            Engine = new Engine(engineSpeed, enginePower);
            Cargo = new Cargo(cargoWeight,cargoType);
            Tires = new List<Tires>()
            {
                new Tires(tire1Age,tire1Pressure),
                new Tires(tire2Age,tire2Pressure),
                new Tires(tire3Age,tire3Pressure),
                new Tires(tire4Age,tire4Pressure),
            };

        }

        public string Model { get; set; }
        public Engine Engine { get; set; }
        public Cargo Cargo { get; set; }
        public List<Tires> Tires { get; set; }

        public override string ToString()
        {
            return Model;
        }
    }
}
