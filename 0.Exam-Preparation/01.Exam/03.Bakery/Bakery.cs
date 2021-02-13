namespace BakeryOpenning
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    public class Bakery
    {
        private string name;
        private int age;
        private HashSet<Employee> employe;
        public Bakery(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            employe = new HashSet<Employee>();
        }
        public string Name { get; set; }

        public int Capacity { get; set; }
        public int Count
        {
            get 
            { 
                return employe.Count;
            }
        }
        public void Add(Employee employee)
        {
            if (Capacity > employe.Count)
            {
                employe.Add(employee);
                
            }
        }
        public Employee GetOldestEmployee()
        {
            Employee oldest = null;

            foreach (var current in employe)
            {
                if (oldest == null || current.Age > oldest.Age)
                {
                    oldest = current;
                }
            }
            return oldest;
        }
        public bool Remove(string name)
        {
            Employee current = employe.FirstOrDefault(x => x.Name == name);
            if (employe.Contains(current))
            {
                return true;
            }
            return false;
        }
        public Employee GetEmployee(string name)
        {

            return employe.FirstOrDefault(x => x.Name == name);

        }
        public string  Report()
        {

            return $"Employees working at Bakery {this.Name}:\n{string.Join(Environment.NewLine, this.employe)}"; 
                
        }
        
    }
}
