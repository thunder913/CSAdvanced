using System;
using System.Linq;
using System.Collections.Generic;

namespace Problem4
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            var dict = new Dictionary<int, int>();
            for (int i = 0; i < count; i++)
            {
                var input = int.Parse(Console.ReadLine());
                if (!dict.ContainsKey(input))
                {
                    dict.Add(input, 0);
                }
                dict[input]++;
            }

            foreach (var item in dict)
            {
                if (item.Value%2==0)
                {
                    Console.WriteLine(item.Key);
                }
            }
        }
    }
}
