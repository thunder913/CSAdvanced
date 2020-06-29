using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace Problem9
{
    class Trainer
    {
        string name;
        public int badges { get; set; } = 0;
        public int countUsed = 0;
        List<Pokemon> pokemons = new List<Pokemon>();



        public Trainer(string Name, Pokemon pokemon) 
        {
            this.name = Name;
            this.pokemons.Add(pokemon);
        }

        public Trainer AddPokemonToTrainer(Trainer trainer, Pokemon pokemon) 
        {
            this.countUsed++;
            trainer.pokemons.Add(pokemon);
            return trainer;
        }

        public bool IsThereAlreadyThisTrailer(Trainer trainer, Trainer currentTrainer) 
        {
            if (currentTrainer.name == trainer.name)
            {
                return true;
            }
            else 
            {
                return false;
            }
        }
        public void PokemonCheck(Trainer trainer, string type) 
        {
            bool hasTheType = false;
            foreach (var item in this.pokemons)
            {
                if (item.GetPokemonType(item) == type)
                {
                    hasTheType = true;
                    break;
                }
            }
            if (hasTheType == true) 
            {
                this.badges++;
            }
            else 
            {
                var toRemove = new List<Pokemon>();
                foreach (var item in pokemons)
                {
                    bool hasToRemove = item.removeHp(item);
                    if (hasToRemove)
                    {
                        toRemove.Add(item);
                    }
                }

                foreach (var item in toRemove)
                {
                    pokemons.Remove(item);
                }
            }
        }

        public int getBadges(Trainer trainer) 
        {
            return this.badges;
        }
        public int getCount(Trainer trainer) 
        {
            return this.countUsed;
        }

        public override string ToString()
        {
            return $"{this.name} {this.badges} {this.pokemons.Count()}";
        }
    }
}
