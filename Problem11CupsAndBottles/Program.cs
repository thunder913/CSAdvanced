using System;
using System.Linq;
using System.Collections.Generic;

namespace Problem11CupsAndBottles
{
    class Program
    {
        static void Main(string[] args)
        {
            var cupQueue = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
            var bottleStack = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
            int wastedWater = 0;

            while (cupQueue.Any() && bottleStack.Any())
            {
                if (bottleStack.Peek() >= cupQueue.Peek())
                {
                    wastedWater += bottleStack.Pop() - cupQueue.Dequeue();
                }
                else
                {
                    cupQueue.Enqueue(cupQueue.Dequeue() - bottleStack.Pop());
                    for (int i = 0; i < cupQueue.Count()-1; i++)
                    {
                        var current = cupQueue.Dequeue();
                        cupQueue.Enqueue(current);
                    }

                }
            }

            if (cupQueue.Any())
            {
                Console.WriteLine($"Cups: {string.Join(" ", cupQueue)}");
            }
            else 
            {
                Console.WriteLine($"Bottles: {string.Join(" ", bottleStack)}");
            }
            Console.WriteLine($"Wasted litters of water: {wastedWater}");
        }
    }
}
