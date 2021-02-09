using System;
using System.Collections.Generic;
using System.Text;

namespace _09.GenericCountMethodDoubles
{
    public class Box<T>
    {
     
        
        public Box(T value)
        
        {
            this.Value = value;
        }

        public T Value { get; set; }


    }
}
