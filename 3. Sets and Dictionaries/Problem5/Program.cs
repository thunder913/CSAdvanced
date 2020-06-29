using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem5
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<char, int>();
            var input = Console.ReadLine();
            foreach (var item in input)
            {
                if (!dict.ContainsKey(item))
                {
                    dict.Add(item, 0);
                }
                dict[item]++;
            }
            dict = dict.OrderBy(x => x.Key).ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key}: {item.Value} time/s");
            }
        }
    }
}
