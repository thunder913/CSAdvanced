using System;
using System.Collections.Generic;
using System.Linq;
namespace Problem_3._Maximum_and_Minimum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack<int>();
            int totalCommands = int.Parse(Console.ReadLine());
            for (int i = 0; i < totalCommands; i++)
            {
                var command = Console.ReadLine().Split().Select(int.Parse).ToArray();
                if (command[0] == 1)
                {
                    stack.Push(command[1]);
                }
                else if (command[0] == 2 && stack.Any())
                {
                    stack.Pop();
                }
                else if (command[0] == 3 && stack.Any())
                {
                    Console.WriteLine(stack.Max());
                }
                else if (command[0] == 4 && stack.Any())
                {
                    Console.WriteLine(stack.Min());
                }
            }

            if (stack.Any())
            {
                Console.WriteLine(string.Join(", ", stack));
            }
        }
    }
}
