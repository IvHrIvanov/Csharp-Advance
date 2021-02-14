using System;

namespace VetClinic
{
    public class StartUp
    {
        static void Main(string[] args)

        {
            // Initialize the repository
            Clinic clinic = new Clinic(20);

            // Initialize entity
            Pet dog = new Pet("Ellias", 5, "Tim");

            // Print Pet
            Console.WriteLine(dog); // Ellias 5 (Tim)

            // Add Pet
            clinic.Add(dog);

            // Remove Pet
            Console.WriteLine(clinic.Remove("Ellias")); // True
            Console.WriteLine(clinic.Remove("Pufa")); // False
        
            Pet cat = new Pet("Bella", 2, "Mia");
            Pet bunny = new Pet("Zak", 4, "Jon");

            clinic.Add(cat);
            clinic.Add(bunny);
          
            // Get Oldest Pet
            Pet oldestPet = clinic.GetOldestPet();
            Console.WriteLine(oldestPet); // Zak 4 (Jon)

            Pet pet = clinic.GetPet("Bella", "Mia");
            Console.WriteLine(pet); // Bella 2 (Mia)
            Console.WriteLine(clinic.Count); // 2

            Console.WriteLine(clinic.GetStatistics());

        }
    }
}
