using System;
using System.Collections.Generic;
using System.Linq;
namespace Problem_4.__Fast_Food
{
    class Program
    {
        static void Main(string[] args)
        {
            var foodAvailable = int.Parse(Console.ReadLine());
            var orders = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var queue = new Queue<int>(orders);
            int biggestOrder = queue.Max();
            
            while (queue.Any())
            {
                if (foodAvailable < queue.Peek())
                {
                    break;
                }
                foodAvailable -= queue.Dequeue();
            }
            Console.WriteLine(biggestOrder);
            if (queue.Any())
            {
                Console.WriteLine($"Orders left: {string.Join(" ", queue)}");
            }
            else 
            {
                Console.WriteLine("Orders complete");
            }
        }
    }
}
