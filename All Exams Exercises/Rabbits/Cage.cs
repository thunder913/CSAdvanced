using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Rabbits
{
    class Cage
    {
        public List<Rabbit> data = new List<Rabbit>();
        public string Name { get; set; }
        public int Capacity { get; set; }

        public int Count => data.Count();

        public Cage(string name, int capacity)
        {
            this.Name = name;
            this.Capacity = capacity;
        }

        public void Add(Rabbit rabbit)
        {
            if (data.Count() + 1 <= this.Capacity)
            {
                data.Add(rabbit);
            }
        }

        public bool RemoveRabbit(string name)
        {
            var rabbit = data.FirstOrDefault(x => x.Name == name);
            if (rabbit != null)
            {
                data.Remove(rabbit);
                return true;
            }
            return false;
        }

        public void RemoveSpecies(string species)
        {
            data.RemoveAll(x => x.Species == species);
        }

        public Rabbit SellRabbit(string name)
        {
            data.FirstOrDefault(x => x.Name == name).Available = false;
            return data.FirstOrDefault(x => x.Name == name);
        }

        public Rabbit[] SellRabbitsBySpecies(string species)
        {
            var list = new List<Rabbit>();
            for (int i = 0; i < this.data.Count(); i++)
            {
                if (data[i].Species == species)
                {
                    data[i].Available = false;
                    list.Add(data[i]);
                }
            }
            return list.ToArray();
        }

        public string Report()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Rabbits available at {this.Name}:");
            foreach (var item in data)
            {
                if (item.Available == true)
                {
                    sb.AppendLine(item.ToString());
                }
            }
            return sb.ToString().TrimEnd();
        }

    }
}
