using System;
using System.Linq;
using System.Collections.Generic;

namespace Frogg
{
    class Program
    {
        static void Main(string[] args)
        {
            var lake = new List<int>();
            lake = Console.ReadLine().Split(", ").Select(int.Parse).ToList();
            var even = new List<int>();
            var odd = new List<int>();
            for (int i = 0; i < lake.Count; i++)
            {
                if (i%2==0)
                {
                    even.Add(lake[i]);
                }
                else
                {
                    odd.Add(lake[i]);
                }
            }

            lake.Clear();
            lake.AddRange(even);
            odd.Reverse();
            lake.AddRange(odd);

            Console.WriteLine(string.Join(", ", lake));
        }
    }
}
