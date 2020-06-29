using System;
using System.Linq;
using System.Collections.Generic;

namespace Problem3PeriodicTable
{
    class Program
    {
        static void Main(string[] args)
        {
            var hashSet = new HashSet<string>();
            var inputs = int.Parse(Console.ReadLine());
            for (int i = 0; i < inputs; i++)
            {
                var input = Console.ReadLine().Split();
                foreach (var item in input)
                {
                    hashSet.Add(item);
                }
            }
            var list = hashSet.OrderBy(x => x).ToList();
            Console.WriteLine(string.Join(" ", list));
        }
    }
}
