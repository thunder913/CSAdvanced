using System;
using System.Linq;
using System.Collections.Generic;
namespace Proble_11_PRFM
{
    class Program
    {
        static void Main(string[] args)
        {
            var people = Console.ReadLine().Split().ToList();
            var command = Console.ReadLine().Split(";");
            var dict = new Dictionary<string, List<string>>();
            while (command[0] != "Print")
            {
                if (command[0] == "Add filter")
                {
                    if (!dict.ContainsKey(command[1]))
                    {
                        dict.Add(command[1], new List<string>());
                    }
                    if (!dict[command[1]].Contains(command[2]))
                    {
                        dict[command[1]].Add(command[2]);
                    }
                }

                else if (command[0] == "Remove filter")
                {
                    dict[command[1]].Remove(command[2]);
                }

                command = Console.ReadLine().Split(";");
            }
            foreach (var key in dict.Keys)
            {
                foreach (var value in dict[key])
                {
                    if (key == "Starts with")
                    {
                        people = people.Where(x => !x.StartsWith(value)).ToList();
                    }
                    else if (key == "Ends with")
                    {
                        people = people.Where(x => !x.EndsWith(value)).ToList();
                    }
                    else if (key == "Length")
                    {
                        people = people.Where(x => x.Length != int.Parse(value)).ToList();
                    }
                    else if (key == "Contains")
                    {
                        people = people.Where(x => !x.Contains(value)).ToList();
                    }
                }
            }
            Console.WriteLine(string.Join(" ", people));
        }
    }
}

