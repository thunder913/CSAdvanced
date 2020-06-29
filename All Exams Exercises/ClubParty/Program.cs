using System;
using System.Linq;
using System.Collections.Generic;

namespace ClubParty
{
    class Program
    {
        static void Main(string[] args)
        {
            var maxCapacity = int.Parse(Console.ReadLine());
            var input = new Stack<string>(Console.ReadLine().Split());
            var queueHalls = new Queue<string>();
            var currentList = new List<int>();
            while (input.Any())
            {
                var current = input.Pop();
            Start:;
                if (int.TryParse(current, out int result))
                {
                    if (!queueHalls.Any())
                    {
                        continue;
                    }
                    else if(currentList.Sum()+result <= maxCapacity)
                    {
                        currentList.Add(result);
                    }
                    else 
                    {
                        Console.WriteLine($"{queueHalls.Dequeue()} -> {string.Join(", ", currentList)}");
                        currentList.Clear();
                        goto Start;
                    }
                }
                else 
                {
                    queueHalls.Enqueue(current);
                }
            }
        }
    }
}
