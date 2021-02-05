using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Engine
    {
        public Engine(string model, int power)
        {
            this.Model = model;
            this.Power = power;
        }
        public Engine(string model, int power, int dispacment)
            : this(model, power)
        {
            Displacment = dispacment;
        }

        public Engine(string model, int power, string efficiency)
            : this(model, power)
        {
            Efficiency = efficiency;
        }

        public Engine(string model, int power, int displacment, string efficiency)
            : this(model, power)
        {
           
            Displacment = displacment;
            Efficiency = efficiency;
        }

        public string Model { get; set; }
        public int Power { get; set; }
        public int? Displacment { get; set; }
        public string Efficiency { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            string displacement = Displacment.HasValue ? Displacment.ToString() : "n/a";
            string efficienci = String.IsNullOrEmpty(Efficiency) ? "n/a" : Efficiency;
            sb.AppendLine($"{Model}:");
            sb.AppendLine($"    Power: {Power}");
            sb.AppendLine($"    Displacement: {displacement}");
            sb.AppendLine($"    Efficiency: {efficienci}");
            return sb.ToString().TrimEnd();
        }
    }
}
