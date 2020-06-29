using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Christmas
{
    class Bag
    {
        List<Present> data;
        public string Color { get; set; }
        public int Capacity { get; set; }

        public Bag(string color, int capacity) 
        {
            this.Color = color;
            this.Capacity = capacity;
            data = new List<Present>();
        }

        public void Add(Present present) 
        {
            if (data.Count()+1<= Capacity)
            {
                data.Add(present);
            }
        }

        public bool Remove(string name) 
        {
            var item = data.FirstOrDefault(x => x.Name == name);
            if (data.Contains(item))
            {
                data.Remove(item);
                return true;
            }
            return false;
        }

        public Present GetHeaviestPresent() 
        {
            var maxValue = data.Max(x => x.Weight);
            return data.FirstOrDefault(x => x.Weight == maxValue);
        }

        public Present GetPresent(string name) => data.FirstOrDefault(x => x.Name == name);

        public int Count => data.Count();

        public string Report() 
        {
            var sb = new StringBuilder();
            sb.AppendLine($"{this.Color} bag contains:");
            foreach (var item in data)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString().TrimEnd();
        }

    }
}
