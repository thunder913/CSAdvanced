using System;
using System.Linq;
using System.Collections.Generic;

namespace Problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            var lenghts = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var n = lenghts[0];
            var m = lenghts[1];
            var hashOne = new HashSet<int>();
            var hasTwo = new HashSet<int>();
            for (int i = 0; i < n; i++)
            {
                hashOne.Add(int.Parse(Console.ReadLine()));
            }
            for (int i = 0; i < m; i++)
            {
                hasTwo.Add(int.Parse(Console.ReadLine()));
            }

            foreach (var itemOne in hashOne)
            {
                foreach (var itemTwo in hasTwo)
                {
                    if (itemOne == itemTwo)
                    {
                        Console.Write(itemOne + " ");
                    }
                }
            }
        }
    }
}
