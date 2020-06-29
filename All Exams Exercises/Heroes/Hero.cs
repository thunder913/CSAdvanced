using System;
using System.Collections.Generic;
using System.Text;

namespace Heroes
{
    class Hero
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public Item Item { get; set; }

        public Hero(string name, int level, Item item) 
        {
            this.Name = name;
            this.Level = level;
            this.Item = item;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Hero: {this.Name} – {this.Level}lvl");
            sb.AppendLine(Item.ToString());
            return sb.ToString().TrimEnd();
        }
    }
}
