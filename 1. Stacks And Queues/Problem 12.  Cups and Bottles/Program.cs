using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_12.__Cups_and_Bottles
{
    class Program
    {
        static void Main(string[] args)
        {
            int wastedWater = 0;
            var queueCups = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
            var stackBottle = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
            while (stackBottle.Any() && queueCups.Any())
            {
                int totalWaterNeededForACup = 0;
                while (totalWaterNeededForACup < queueCups.Peek() && stackBottle.Any())
                {
                    totalWaterNeededForACup += stackBottle.Pop();
                }
                if (totalWaterNeededForACup >= queueCups.Peek())
                {
                    wastedWater += totalWaterNeededForACup - queueCups.Dequeue();
                }
            }
            if (queueCups.Any())
            {
                Console.WriteLine($"Cups: {string.Join(" ", queueCups)}");
            }
            else 
            {
                Console.WriteLine($"Bottles: {string.Join(" ",stackBottle)}");
            }
            Console.WriteLine($"Wasted litters of water: {wastedWater}");
        }
    }
}
