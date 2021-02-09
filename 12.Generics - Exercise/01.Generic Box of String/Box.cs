using System;
using System.Collections.Generic;
using System.Text;

namespace _01.Generic_Box_of_String
{
    class Box<T>
    {
        public Box(T value)
        {
            Value = value;
        }

        public T Value { get; set; }

        public override string ToString()
        {
            Type getType = this.Value.GetType();
            string valueName =getType.FullName; 

            return $"{valueName}: {this.Value} "; 
        }
    }
}