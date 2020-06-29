using System;
using System.Collections.Generic;
using System.Text;

namespace Rabbits
{
    class Rabbit
    {
        public string Name { get; set; }
        public string Species { get; set; }
        public bool Available { get; set; } = true;

        public Rabbit(string name, string species) 
        {
            this.Name = name;
            this.Species = species;
        }

        public override string ToString()
        {
            return $"Rabbit ({this.Species}): {this.Name}";
        }
    }
}
