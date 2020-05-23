using System;
using System.Linq;
using System.Collections.Generic;

namespace Problem4FastFood
{
    class Program
    {
        static void Main(string[] args)
        {
            var totalFood = int.Parse(Console.ReadLine());
            var queue = new Queue<int>();
            var orders = Console.ReadLine().Split().Select(int.Parse);
            Console.WriteLine(orders.Max());
            foreach (var item in orders)
            {
                queue.Enqueue(item);
            }
            int highestOrder = -1;
            for (int i = 0; i < orders.Count(); i++)
            {
                int currentNum = queue.Peek();
                if (currentNum <= totalFood)
                {
                    totalFood -= currentNum;
                    queue.Dequeue(); 
                }
            }
            if (!queue.Any())
            {
                Console.WriteLine("Orders complete");
            }
            else 
            {
                Console.WriteLine("Orders left: " + string.Join(" ", queue));
            }

        }
    }
}


