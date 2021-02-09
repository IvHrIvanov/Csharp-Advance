using System;
using System.Collections.Generic;
using System.Text;

namespace _05.GenericCountMethodStrings
{
    class Box<T>
        
    {
        public Box(T value)
           
        {
            Value = value;
        }

        public T Value { get; set; }


       

    }
}
