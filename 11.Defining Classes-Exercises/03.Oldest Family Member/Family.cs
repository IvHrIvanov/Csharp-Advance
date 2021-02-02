using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClasses
{
    public class Family
    {

        public List<Person> Members { get; set; }
        public Family()
        {
            this.Members = new List<Person>();
        }
        public void AddMember(Person person)
        {
            Members.Add(person);
        }
        public Person GetOldMember()
        {
            Person person = Members.OrderByDescending(p => p.Age).FirstOrDefault();

            return person;

        }


    }
}
