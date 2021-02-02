using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DefiningClasses
{
    public class People
    {

        public List<Person> Members { get; set; }
        public People()
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
