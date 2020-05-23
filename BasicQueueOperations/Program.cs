using System;
using System.Linq;
using System.Collections.Generic;

namespace BasicQueueOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            var queue = new Queue<int>();
            var input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int toPush = input[0];
            int toPop = input[1];
            int num = input[2];

            for (int i = 0; i < toPush; i++)
            {
                queue.Enqueue(numbers[i]);
            }

            for (int i = 0; i < toPop; i++)
            {
                queue.Dequeue();
            }

            if (queue.Contains(num))
            {
                Console.WriteLine("true");
            }
            else if (!queue.Any())
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(queue.Min());

            }
        }
    }
}
