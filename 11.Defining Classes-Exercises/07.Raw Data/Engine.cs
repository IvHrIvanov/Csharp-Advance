using System;
using System.Collections.Generic;
using System.Text;

namespace _07.Raw_Data
{
    public class Engine
    {
        private int speed;
        private int power;

        public Engine(int speed,int power)
        {
            Speed = speed;
            Power = power;
        }
        public int Speed
        {
            get
            {
                return speed;
            }
            set
            {
                speed = value;
            }
        }
        public int Power
        {
            get
            {
                return this.speed;
            }
            set
            {
                speed = value;
            }
        }

    }
}
