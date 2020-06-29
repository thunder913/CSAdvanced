using System;
using System.Collections.Generic;
using System.Linq;
namespace Problem_2._Basic_Queue_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputs = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var toRemove = inputs[1];
            var numberToLookFor = inputs[2];
            var queue = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
            for (int i = 0; i < toRemove; i++)
            {
                if (queue.Any())
                {
                    queue.Dequeue();
                }
                else
                {
                    break;
                }
            }
            if (queue.Contains(numberToLookFor))
            {
                Console.WriteLine("true");
            }
            else if (queue.Any())
            {
                Console.WriteLine(queue.Min());
            }
            else 
            {
                Console.WriteLine(0);
            }

        }
    }
}
