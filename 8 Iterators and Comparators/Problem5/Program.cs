using System;
using System.Linq;
using System.Collections.Generic;

namespace Problem5
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();
            var People = new List<Person>();
            while (input[0] != "END") 
            {
                var name = input[0];
                var age = int.Parse(input[1]);
                var city = input[2];
                var person = new Person(name,age,city);
                People.Add(person);
                input = Console.ReadLine().Split();
            }
            int matches = 0;
            var toCompareIndex = int.Parse(Console.ReadLine());
            var toComparePerson = People[--toCompareIndex];
            foreach (var person in People)
            {
                if (toComparePerson.CompareTo(person) == 1)
                {
                    matches++;
                }
            }
            if (matches!= 1)
            {
                int maxPeople = People.Count;
                Console.WriteLine($"{matches} {maxPeople - matches} {maxPeople}");
            }
            else 
            {
                Console.WriteLine($"No matches");
            }
        }
    }
}
