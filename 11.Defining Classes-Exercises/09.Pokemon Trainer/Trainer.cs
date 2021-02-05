using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClasses
{
   public class Trainer
    {
        private int numberOfBadjets;
        private string trainerName;
        private List<Pokemon> pokemon;

        public Trainer(string name)
        {
            Name = name;
            NumberBadges = 0;
            Pokemon = new List<Pokemon>();
        }
       
        public string Name { get; set; }
        public int NumberBadges { get; set; }
        public List<Pokemon> Pokemon { get; set; }
        
        public void Badjes()
        {
            NumberBadges++;
        }
    }
}
