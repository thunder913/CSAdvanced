using System;
using System.Collections.Generic;
using System.Linq;
namespace Problem7TruckTour
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalPumps = int.Parse(Console.ReadLine());
            var queueDistance = new Queue<int>();
            var queueFuel = new Queue<int>();
            for (int i = 0; i < totalPumps; i++)
            {
                var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                queueFuel.Enqueue(input[0]);
                queueDistance.Enqueue(input[1]);
            }
            var fuelSaved = new List<int>(queueFuel);
            var distanceSaved = new List<int>(queueDistance);
            for (int i = 0; i < totalPumps; i++)
            {
                int currentFuel = 0;
                for (int j = 0; j < totalPumps; j++)
                {
                    int fuel = queueFuel.Dequeue();
                    int distance = queueDistance.Dequeue();
                    if (currentFuel + fuel < distance)
                    {
                        break;
                    }
                    currentFuel += fuel - distance;
                    if (j == totalPumps-1)
                    {
                        Console.WriteLine(i);
                        return;
                    }
                }
                queueFuel = new Queue<int>(fuelSaved);
                queueDistance = new Queue<int>(distanceSaved);
                for (int k = 0; k <= i; k++)
                {
                    int currentF = queueFuel.Dequeue();
                    int currentD = queueDistance.Dequeue();
                    queueFuel.Enqueue(currentF);
                    queueDistance.Enqueue(currentD);
                }
                
            }
        }
    }
}
