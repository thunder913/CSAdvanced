using System;
using System.Linq;
using System.Collections.Generic;

namespace Problem9
{
    class Program
    {
        static void Main(string[] args)
        {
            var trainers = new List<Trainer>();
            var input = Console.ReadLine().Split();
            while (input[0] != "Tournament")
            {
                string trainerName = input[0];
                string pokemonName = input[1];
                string pokemonElement = input[2];
                int pokemonHealth = int.Parse(input[3]);
                var pokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);
                var trainer = new Trainer(trainerName, pokemon);
                bool doesItAlreadyHaveIt = false;
                int index = 0;
                foreach (var item in trainers)
                {
                    bool isItIn = item.IsThereAlreadyThisTrailer(item, trainer);
                    if (isItIn == true)
                    {
                        doesItAlreadyHaveIt = true;
                        break;
                    }
                    index++;
                }
                if (doesItAlreadyHaveIt) 
                {
                    trainers[index] = trainers[index].AddPokemonToTrainer(trainers[index], pokemon);
                }
                else 
                {
                    trainers.Add(trainer);
                }
                input = Console.ReadLine().Split();
            }

            var command = Console.ReadLine();
            while (command != "End")
            {
                for (int i = 0; i < trainers.Count(); i++)
                {
                    trainers[i].PokemonCheck(trainers[i], command);
                }
                command = Console.ReadLine();
            }

            var printList = trainers.OrderByDescending(x=>x.getBadges(x)).ToList();
            foreach (var item in printList)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
