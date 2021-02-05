using System;
using System.Collections.Generic;
using System.Text;

namespace _07.Raw_Data
{
    public class Cargo
    {
        private int weight;
        private string type;

        public Cargo(int weight, string type)
        {
            Weight = weight;
            Type = type;
        }

        public int Weight { get; set; }
        public string Type { get; set; }

    }
}
