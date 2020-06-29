using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Heroes
{
    class HeroRepository
    {
        List<Hero> data;

        public HeroRepository() 
        {
            data = new List<Hero>();
        }

        public void Add(Hero hero) 
        {
            data.Add(hero);
        }

        public void Remove(string name) 
        {
            var hero = data.FirstOrDefault(x => x.Name == name);
            data.Remove(hero);
        }

        public Hero GetHeroWithHighestStrength() 
        {
            var maxStr = data.Max(x => x.Item.Strength);
            return data.FirstOrDefault(x => x.Item.Strength == maxStr);
        }
        public Hero GetHeroWithHighestAbility()
        {
            var maxAb = data.Max(x => x.Item.Ability);
            return data.FirstOrDefault(x => x.Item.Ability == maxAb);
        }
        public Hero GetHeroWithHighestIntelligence()
        {
            var maxInt = data.Max(x => x.Item.Intelligence);
            return data.FirstOrDefault(x => x.Item.Intelligence == maxInt);
        }

        public int Count => data.Count();

        public override string ToString()
        {
            var sb = new StringBuilder();
            foreach (var item in data)
            {
                sb.AppendLine(item.ToString());
            }

            return sb.ToString().TrimEnd();
        }
    }
}
