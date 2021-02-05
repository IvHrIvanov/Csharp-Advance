using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {

            List<Trainer> trainers = new List<Trainer>();

            string[] command = Console.ReadLine().Split(" ");

            while (command[0] != "Tournament")
            {
                string trainerName = command[0];
                string pokemonName = command[1];
                string pokemonElement = command[2];
                int pokemonHealth = int.Parse(command[3]);
                Trainer trainer = trainers.FirstOrDefault(n => n.Name == trainerName);
                Pokemon pokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);
                if (trainer != null)
                {
                    trainer.Pokemon.Add(new Pokemon(pokemonName, pokemonElement, pokemonHealth));
                }
                else
                {
                    Trainer newTrainer = new Trainer(trainerName);
                    newTrainer.Pokemon.Add(new Pokemon(pokemonName, pokemonElement, pokemonHealth));
                    trainers.Add(newTrainer);
                }

                command = Console.ReadLine().Split(" ");
            }

            string fightElements = Console.ReadLine();
            ;
            while (fightElements != "End")
            {

                foreach (Trainer item in trainers)
                {


                    if (item.Pokemon.Any(x => x.Element == fightElements))
                    {
                        item.Badjes();
                    }
                    else
                    {

                        foreach (var curPokemon in item.Pokemon)
                        {
                            curPokemon.ReduceHealth();


                        }


                    }
                    item.Pokemon.RemoveAll(x => x.Health <= 0);
                }

                fightElements = Console.ReadLine();
            }

            foreach (Trainer item in trainers.OrderByDescending(x => x.NumberBadges))
            {
                Console.WriteLine($"{item.Name} {item.NumberBadges} {item.Pokemon.Count}");
            }
        }
    }
}