using System;
using System.Collections.Generic;
using System.Text;

namespace Problem9
{
    class Pokemon
    {
        string name;
        string element;
        int health;
        public Pokemon(string Name, string Element, int Health)
        {
            this.name = Name;
            this.element = Element;
            this.health = Health;
        }

        public string GetPokemonType(Pokemon pokemon) 
        {
            return pokemon.element;
        }

        public bool removeHp(Pokemon pokemon) 
        {
            bool hasToRemove = false;
            pokemon.health -= 10;
            if (pokemon.health <= 0)
            {
                hasToRemove = true;
            }
            return hasToRemove;
        }
    }
}
