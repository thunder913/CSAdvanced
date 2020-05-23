using System;
using System.Linq;
using System.Collections.Generic;

namespace MaxAndMinElements
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack<int>();
            int commands = int.Parse(Console.ReadLine());

            for (int i = 0; i < commands; i++)
            {
                var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                var firstNNum = input[0];
                if (firstNNum == 1)
                {
                    stack.Push(input[1]);
                }
                else if (firstNNum == 2)
                {
                    stack.Pop();
                }
                else if (firstNNum == 3)
                {
                    if (stack.Any())
                    {
                        Console.WriteLine(stack.Max());
                    }
                    
                }
                else if (firstNNum == 4)
                {
                    if (stack.Any())
                    {
                        Console.WriteLine(stack.Min());
                    }
                }
            }

            Console.WriteLine(string.Join(", ", stack));
        }
    }
}
