using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Car
    {
        public Car(string model, Engine engine)
        {
            Model = model;
            Engine = engine;
        }
        public Car(string model, Engine engine, double weight)
            : this(model, engine)
        {
            Weight = weight;
        }
        public Car(string model, Engine engine, string color)
            : this(model, engine)
        {
            Color = color;
        }
        public Car(string model, Engine engine, double weight, string color)
        : this(model, engine)
        {
            Weight = weight;
            Color = color;
        }
        public string Model { get; set; }
        public Engine Engine { get; set; }
        public double? Weight { get; set; }

        public string Color { get; set; }

        public override string ToString()
        {
            string isValidWeight = Weight.HasValue ? Weight.ToString() : "n/a";
            string isValidColor = String.IsNullOrEmpty(this.Color)?"n/a": this.Color;
            var sb = new StringBuilder();
            sb.AppendLine($"{Model}:");
            sb.AppendLine($"  {Engine}");
            sb.AppendLine($"  Weight: {isValidWeight}");
            sb.AppendLine($"  Color: {isValidColor}");
            return sb.ToString().TrimEnd();
        }
    }
}
