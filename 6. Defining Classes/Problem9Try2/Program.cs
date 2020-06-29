using System;
using System.Linq;
using System.Collections.Generic;
namespace Problem9Try2
{
    class Program
    {
        static void Main(string[] args)
        {
            var trainers = new List<Trainer>();
            var input = Console.ReadLine().Split();
            while (input[0] != "Tournament")
            {
                var trainerName = input[0];
                var pokemonName = input[1];
                var pokemonElement = input[2];
                var pokemonHealth = int.Parse(input[3]);
                Pokemon pokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);
                bool isAlreadyIn = false;
                int index = 0;
                foreach (var person in trainers)
                {
                    if (person.name == trainerName)
                    {
                        isAlreadyIn = true;
                        break;
                    }
                    index++;
                }
                if (isAlreadyIn) 
                {
                    trainers[index].AddPokemon(pokemon);
                }
                else 
                {
                    Trainer train = new Trainer(trainerName, pokemon);
                    trainers.Add(train);
                }
                input = Console.ReadLine().Split();
            }

            var command = Console.ReadLine();
            while (command != "End")
            {
                foreach (var item in trainers)
                {
                    item.CheckTrainerOwnerType(item, command);
                }

                command = Console.ReadLine();
            }

            trainers = trainers.OrderByDescending(x => x.badges).ToList();
            foreach (var trainer in trainers)
            {
                Console.WriteLine($"{trainer.name} {trainer.badges} {trainer.pokemons.Count()}");
            }
        }
    }
}
