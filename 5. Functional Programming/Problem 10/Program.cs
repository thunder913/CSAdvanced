using System;
using System.Linq;
using System.Collections.Generic;

namespace Problem_10
{
    class Program
    {
        static void Main(string[] args)
        {
            var people = Console.ReadLine().Split().ToList();
            var command = Console.ReadLine().Split();
            var otherList = new List<string>();
            
            while (command[0] != "Party!")
            {
                Func<string, List<string>, List<string>> func = command[1] switch
                {
                    "StartsWith" => (s, l) => l.Where(x => x.StartsWith(s)).ToList(),
                    "EndsWith" => (s, l) => l.Where(x => x.EndsWith(s)).ToList(),
                    "Length" => (s, l) => l.Where(x => x.Length == int.Parse(s)).ToList(),
                    _ => (s, l) => new List<string>()
                };
                if (command[0] == "Double")
                {
                    otherList = func(command[2], people).ToList();
                    foreach (var item in otherList)
                    {
                        people.Add(item);
                    }
                    otherList.Clear();
                    
                }
                else if(command[0] == "Remove")
                {
                    otherList = func(command[2], people).ToList();
                    foreach (var item in otherList)
                    {
                        people.RemoveAll(x => x==item);
                    }
                    otherList.Clear();
                }

                command = Console.ReadLine().Split();
            }
            if (people.Any())
            {
                Console.Write(string.Join(", ", people) + " are going to the party!");
            }
            else 
            {
                Console.WriteLine("Nobody is going to the party!");
            }
        }
    }
}
