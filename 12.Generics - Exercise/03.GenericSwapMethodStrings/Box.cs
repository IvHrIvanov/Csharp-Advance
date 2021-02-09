using System;
using System.Collections.Generic;
using System.Text;

namespace _03.GenericSwapMethodStrings
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
            Type typeName = Value.GetType();
            string currentName = typeName.FullName;
            return $"{currentName}: {this.Value}";
        }
    }
}
