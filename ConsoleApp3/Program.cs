using System;
using System.Collections.Generic;
using System.Linq;

namespace StackAndQueues
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack<int>();
            var input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int toPush = input[0];
            int toPop = input[1];
            int num = input[2];

            for (int i = 0; i < toPush; i++)
            {
                stack.Push(numbers[i]);
            }

            for (int i = 0; i < toPop; i++)
            {
                stack.Pop();
            }

            if (stack.Contains(num))
            {
                Console.WriteLine("true");
            }
            else if(!stack.Any())
            {
                Console.WriteLine(0);
            }
            else 
            {
                Console.WriteLine(stack.Min());

            }
        }
    }
}
