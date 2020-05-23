using System;
using System.Linq;
using System.Collections.Generic;

namespace Problem11KeyRevolver
{
    class Program
    {
        static void Main(string[] args)
        {
            int bulletPrice = int.Parse(Console.ReadLine());
            int magazine = int.Parse(Console.ReadLine());
            var stackBullet = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
            var queueLocks = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
            int currentMag = magazine;
            int cost = 0;
            while (stackBullet.Any() && queueLocks.Any())
            {
                int currentBullet = stackBullet.Pop();
                cost += bulletPrice;
                int currentLock = queueLocks.Peek();
                if (currentBullet <= currentLock)
                {
                    queueLocks.Dequeue();
                    Console.WriteLine("Bang!");
                }
                else 
                {
                    Console.WriteLine("Ping!");
                }
                currentMag--;
                if (currentMag==0 && stackBullet.Any())
                {
                    Console.WriteLine($"Reloading!");
                    currentMag = magazine;
                }
            }

            if (!queueLocks.Any())
            {
                int value = int.Parse(Console.ReadLine());
                Console.WriteLine($"{stackBullet.Count()} bullets left. Earned ${value-cost}");
            }
            else 
            {
                Console.WriteLine($"Couldn't get through. Locks left: {queueLocks.Count()}");
            }
        }
    }
}
