using System;
using System.Collections.Generic;
using System.Text;

namespace _07.Raw_Data
{
    public class Tires
    {
        private int age;
        private double preasure;

        public Tires(int age, double preasure)
        {
            Age = age;
            Preasure = preasure;
        }

        public int Age { get; set; }
        public double Preasure { get; set; }

    }
}
