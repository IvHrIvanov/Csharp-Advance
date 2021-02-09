using System;
using System.Collections.Generic;
using System.Text;

namespace _02.GenericBoxofInteger
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
            string currentTypeName = getType.FullName;

            return $"{currentTypeName}: {this.Value}";

        }
    }
}
