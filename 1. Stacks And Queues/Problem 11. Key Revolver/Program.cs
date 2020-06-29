using System;
using System.Collections.Generic;
using System.Linq;
namespace Problem_11._Key_Revolver
{
    class Program
    {
        static void Main(string[] args)
        {
            int bulletCost = int.Parse(Console.ReadLine());
            int gunBarrel = int.Parse(Console.ReadLine());
            var bullets = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var locks = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int value = int.Parse(Console.ReadLine());
            var stackBullets = new Stack<int>(bullets);
            var queueLocks = new Queue<int>(locks);
            int i = 1;
            for (i = 1; i <= bullets.Length && queueLocks.Any(); i++)
            {
                if (stackBullets.Peek() <= queueLocks.Peek())
                {
                    Console.WriteLine("Bang!");
                    queueLocks.Dequeue();
                }
                else
                {
                    Console.WriteLine("Ping!");
                }
                stackBullets.Pop();
                if (i%gunBarrel == 0 && stackBullets.Any())
                {
                    Console.WriteLine("Reloading!");
                }
            }
            if (queueLocks.Any())
            {
                Console.WriteLine($"Couldn't get through. Locks left: {queueLocks.Count}");
            }
            else 
            {
                Console.WriteLine($"{stackBullets.Count} bullets left. Earned ${value - (i-1)*bulletCost}");
            }
        }
    }
}
