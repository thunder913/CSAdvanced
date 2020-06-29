using System;
using System.Collections.Generic;
using System.Linq;
namespace Problem_7.__Truck_Tour
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalPumps = int.Parse(Console.ReadLine());
            int pumpsVisited = 0;
            long fuelLoaded = 0;
            int index = 0;
            var queue = new Queue<int>();
            for (int i = 0; i < totalPumps; i++)
            {
                int[] pump = Console.ReadLine().Split().Select(int.Parse).ToArray();
                queue.Enqueue(pump[0] - pump[1]);
            }
            var testQueue = new Queue<int>(queue);
            while (pumpsVisited != totalPumps)
            {
                if (fuelLoaded + testQueue.Peek() >= 0)
                {
                    pumpsVisited++;
                    int removeFuel = testQueue.Dequeue();
                    fuelLoaded += removeFuel;
                    
                }
                else 
                {
                    fuelLoaded = 0;
                    pumpsVisited = 0;
                    index++;
                    testQueue = new Queue<int>(queue);
                    for (int i = 0; i < index; i++)
                    {
                        int num = testQueue.Dequeue();
                        testQueue.Enqueue(num);
                    }
                }
            }
            Console.WriteLine(index);
        }
    }
}
