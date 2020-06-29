using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstBox = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
            var secondBox = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
            var claimedItems = 0;

            while (firstBox.Any() && secondBox.Any())
            {
                var sum = firstBox.Peek() + secondBox.Peek();
                if (sum % 2 == 0)
                {
                    claimedItems += firstBox.Dequeue() + secondBox.Pop();
                }
                else
                {
                    firstBox.Enqueue(secondBox.Pop());
                }
            }

            if (!firstBox.Any())
            {
                Console.WriteLine($"First lootbox is empty");
            }
            else
            {
                Console.WriteLine($"Second lootbox is empty");
            }
            if (claimedItems < 100)
            {
                Console.WriteLine($"Your loot was poor... Value: {claimedItems}");
            }
            else 
            {
                Console.WriteLine($"Your loot was epic! Value: {claimedItems}");
            }
        }
    }
}
