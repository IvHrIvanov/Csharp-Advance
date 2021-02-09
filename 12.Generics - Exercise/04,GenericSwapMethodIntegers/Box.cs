using System;
using System.Collections.Generic;
using System.Text;

namespace _04_GenericSwapMethodIntegers
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
            Type getType = Value.GetType();
            string currentType = getType.FullName;

            return $"{currentType}: {this.Value}";
        }
    }
}
