using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem5FashionBoutique
{
    class Program
    {
        static void Main(string[] args)
        {
            var clothes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var stack = new Stack<int>(clothes);
            var rackCapacity = int.Parse(Console.ReadLine());
            int totalRacks = 1;
            int currentRack = 0;
            while (stack.Any())
            {
                int currentCloth = stack.Peek();
                if (currentRack + currentCloth <= rackCapacity)
                {
                    currentRack += currentCloth;
                }
                else 
                {
                    totalRacks++;
                    currentRack = currentCloth;
                }
                stack.Pop();
            }

            Console.WriteLine(totalRacks);
        }
    }
}
