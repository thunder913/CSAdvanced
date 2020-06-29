using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClasses
{
    class Family
    {
        public List<Person> people = new List<Person>();
        public void AddMember(Person member) 
        {
            people.Add(member);
        }
        public Person GetOldestMember() 
        {
            int maxAge = int.MinValue;
            people = people.OrderByDescending(x => x.Age).ToList();
            Person returnValue = people[0];
            return returnValue;
        }

        public List<Person> printOlderThan30() 
        {
            people = people.OrderBy(x => x.Name).ToList();
            List<Person> toPrint = new List<Person>();
            toPrint = people.Where(x => x.Age > 30).ToList();
            return toPrint;
        }
    }
}
