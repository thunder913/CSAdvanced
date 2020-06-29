using System;
using System.Collections.Generic;
using System.Linq;

namespace DatingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var males = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
            var females = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
            int matches = 0;

            while (males.Any()&&females.Any())
            {
                if (males.Peek()<=0)
                {
                    males.Pop();
                    continue;
                }
                else if (females.Peek()<=0)
                {
                    females.Dequeue();
                }
                else if (males.Peek()%25==0)
                {
                    males.Pop();males.Pop();
                }
                else if (females.Peek()%25==0)
                {
                    females.Dequeue();females.Dequeue();
                }
                else if (males.Peek()==females.Peek())
                {
                    females.Dequeue();
                    males.Pop();
                    matches++;
                }
                else 
                {
                    females.Dequeue();
                    males.Push(males.Pop() - 2);
                }
            }

            Console.WriteLine($"Matches: {matches}");
            if (!males.Any())
            {
                Console.WriteLine("Males left: none");
            }
            else 
            {
                Console.WriteLine($"Males left: {string.Join(", ", males)}");
            }
            if (!females.Any())
            {
                Console.WriteLine("Females left: none");
            }
            else 
            {
                Console.WriteLine($"Females left: {string.Join(", ", females)}");
            }
        }
    }
}
