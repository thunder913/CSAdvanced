using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Problem5
{
    class Person : IComparable<Person>
    {
        public string Name { get; set; }
        public  int Age { get; set; }
        public string Town { get; set; }

        public Person(string name, int age, string town) 
        {
            this.Name = name;
            this.Age = age;
            this.Town = town;
        }

        public Person() 
        {
            
        }
        public int CompareTo([AllowNull] Person other)
        {
            int nameEq = this.Name.CompareTo(other.Name);
            int ageEq = this.Age.CompareTo(other.Age);
            int townEq = this.Town.CompareTo(other.Town);
            if (nameEq==0 && ageEq==0 && townEq==0)
            {
                return 1;
            }
            return 0;
        }
    }
}
