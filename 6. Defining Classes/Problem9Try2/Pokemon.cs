using System;
using System.Collections.Generic;
using System.Text;

namespace Problem9Try2
{
    class Pokemon
    {
        string name;
        string element;
        public int health;

        public Pokemon(string Name, string Element, int Health) 
        {
            this.name = Name;
            this.element = Element;
            this.health = Health;
        }
        public bool DoesItMatch(Pokemon pokemon, string typeNeeded) 
        {
            if (pokemon.element == typeNeeded)
            {
                return true;
            }else
            {
                return false;
            }
        }
    }
}
