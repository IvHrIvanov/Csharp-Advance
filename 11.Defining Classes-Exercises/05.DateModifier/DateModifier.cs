using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public static class DateModifier
    {
        public static int TotalDays(string firstInput,string secondInput)
        {
            DateTime firstDate = DateTime.Parse(firstInput);
            DateTime secondDate = DateTime.Parse(secondInput);

            TimeSpan  diff = firstDate - secondDate;
            return Math.Abs(diff.Days);
        }
    }
}
