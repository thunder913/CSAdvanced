using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace Problem9Try2
{
    class Trainer
    {
        public string name { get; set; }
        public int badges = 0;
        public List<Pokemon> pokemons = new List<Pokemon>();
        public int appearances = 1;

        public Trainer(string Name, Pokemon pokemon) 
        {
            this.name = Name;
            pokemons.Add(pokemon);
        }

        public void AddPokemon(Pokemon pokemon) 
        {
            this.pokemons.Add(pokemon);
        }

        public void CheckTrainerOwnerType(Trainer trainer, string typeNeeded)
        {
            bool match = false;
            foreach (var item in trainer.pokemons)
            {
                match = item.DoesItMatch(item, typeNeeded);
                if (match == true)
                {
                    appearances++;
                    trainer.badges++;
                    break;
                }
            }
            if (match==false)
            {
                trainer.pokemons.ForEach(x => x.health -= 10);
                trainer.pokemons = trainer.pokemons.Where(x => x.health > 0).ToList();
            }
            
        }
    }
}
