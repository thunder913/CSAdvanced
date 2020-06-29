using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Guild
{
    class Guild
    {
        List<Player> roster = new List<Player>();

        public string Name { get; set; }
        public int Capacity { get; set; }

        public int Count => roster.Count();
        public Guild(string name, int capacity) 
        {
            this.Name = name;
            this.Capacity = capacity;
        }

        public void AddPlayer(Player player) 
        {
            if (this.roster.Count()+1 <= Capacity)
            {
                this.roster.Add(player);
            }
        }

        public bool RemovePlayer(string name) 
        {
            var toRemove = roster.FirstOrDefault(x => x.Name == name);
            if (toRemove!= null)
            {
                roster.Remove(toRemove);
                return true;
            }
            return false;
        }

        public void PromotePlayer(string name) 
        {
            roster.FirstOrDefault(x => x.Name == name).Rank = "Member";
        }

        public void DemotePlayer(string name) 
        {
            roster.FirstOrDefault(x => x.Name == name).Rank = "Trial";
        }

        public Player[] KickPlayersByClass(string clas) 
        {
            var removed = new List<Player>(); 
            foreach (var item in roster)
            {
                if (item.Class == clas)
                {
                    removed.Add(item);
                }
            }
            roster.RemoveAll(x => x.Class == clas);
            return removed.ToArray();
        }

        public string Report()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Players in the guild: {this.Name}");
            foreach (var item in roster)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString().TrimEnd();
        }

    }
}
