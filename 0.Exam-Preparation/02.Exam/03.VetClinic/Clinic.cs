using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VetClinic
{
    public class Clinic
    {
        private List<Pet> pet;
        public Clinic(int capacity)
        {
            Capacity = capacity;
            Pet = pet;
        }
        public int Count { get; set; }
        public int Capacity { get; set; }

        public List<Pet> Pet { get; set; }

        public void Add(Pet pet)
        {
            if (Count < Capacity)
            {
                if (this.Pet == null)
                {
                    this.Pet = new List<Pet>();
                }
                Count++;
                this.Pet.Add(pet);
            }
        }
        public bool Remove(string name)
        {
            Pet current = Pet.FirstOrDefault(x => x.Name == name);
            if (Pet.Contains(current))
            {
                Count--;
                Pet.Remove(current);
                return true;
            }
            return false;

        }

        public Pet GetOldestPet()
        {

            Pet oldestPet = null;
            foreach (Pet item in this.Pet)
            {
                if (oldestPet == null || item.Age > oldestPet.Age)
                {
                    oldestPet = item;
                }

            }
            return oldestPet;
        }

        public string GetStatistics()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("The clinic has the following patients:");
            foreach (Pet item in this.Pet)
            {
                sb.AppendLine($"Pet {item.Name} with owner: {item.Owner}");
            }
            
            return sb.ToString().TrimEnd();
        }

        public Pet GetPet(string name, string owner)
        {
            Pet current = null;
            bool flag = false;
            foreach (Pet item in Pet)
            {
                if(item.Name==name && item.Owner==owner)
                {
                    flag = true;
                    current = item;
                }
            }
            if (flag)
            {
                return current;
            }
            return null;
        }
    }


}

