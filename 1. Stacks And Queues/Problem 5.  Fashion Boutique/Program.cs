using System;
using System.Collections.Generic;
using System.Linq;
namespace Problem_5.__Fashion_Boutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] clothings = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rackCapacity = int.Parse(Console.ReadLine());
            int racksUsed = 1;
            int currentRack = 0;
            var stack = new Stack<int>(clothings);
            while (stack.Any())
            {
                if (currentRack + stack.Peek() > rackCapacity)
                {
                    racksUsed++;
                    currentRack = 0;
                }
                currentRack += stack.Pop();
            }
            Console.WriteLine(racksUsed);
        }
    }
}
