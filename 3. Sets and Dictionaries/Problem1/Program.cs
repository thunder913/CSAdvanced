using System;
using System.Collections.Generic;
using System.Linq;
namespace Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            var set = new HashSet<string>();
            var inputs = int.Parse(Console.ReadLine());
            for (int i = 0; i < inputs; i++)
            {
                set.Add(Console.ReadLine());
            }
            for (int i = 0; i < set.Count(); i++)
            {
                
                Console.WriteLine(set.ElementAt(i));
            }
        }
    }
}
