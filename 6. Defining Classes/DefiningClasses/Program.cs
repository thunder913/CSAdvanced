using System;
using System.Collections.Generic;
namespace DefiningClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Family family = new Family();
            int peopleToEnter = int.Parse(Console.ReadLine());
            for (int i = 0; i < peopleToEnter; i++)
            {
                var personInput = Console.ReadLine().Split();
                var person = new Person(personInput[0], int.Parse(personInput[1]));
                family.AddMember(person);
            }
            List<Person> printMembers = family.printOlderThan30();
            for (int i = 0; i < printMembers.Count; i++)
            {
                Console.WriteLine($"{printMembers[i].Name} - {printMembers[i].Age}");
            }
        }
    }
}
