using System;
using System.Linq;
using System.Collections.Generic;

namespace Problem6
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputs = int.Parse(Console.ReadLine());
            var dict = new Dictionary<string, Dictionary<string,int>>();
            for (int i = 0; i < inputs; i++)
            {
                var input = Console.ReadLine().Split(" -> ").ToList();
                var color = input[0];

                var clothes = input[1].Split(",");
                if (!dict.ContainsKey(color))
                {
                    dict.Add(color, new Dictionary<string, int>());
                }
                foreach (var item in clothes)
                {
                    if (!dict[color].ContainsKey(item))
                    {
                        dict[color].Add(item, 0);
                    }
                    dict[color][item]++;
                }
            }

            var itemToFind = Console.ReadLine().Split();
            var colorToLook = itemToFind[0];
            var clothingToLook = itemToFind[1];

            foreach (var (key,value) in dict)
            {
                Console.WriteLine($"{key} clothes:");
                foreach (var (cloth, count) in value)
                {
                    Console.Write($"* {cloth} - {count}");
                    if (colorToLook == key && clothingToLook == cloth)
                    {
                        Console.WriteLine(" (found!)");
                    }
                    else 
                    {
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}
