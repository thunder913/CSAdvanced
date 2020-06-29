using System;
using System.Linq;
using System.Collections.Generic;
namespace C_Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputs = (Console.ReadLine().Split().Select(int.Parse).ToArray());
            var elementsToPush = inputs[0];
            var elementsToPop = inputs[1];
            var hasElement = inputs[2];
            var stack = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
            
            for (int i = 0; i < elementsToPop; i++)
            {
                if (stack.Any())
                {
                    stack.Pop();
                }
                else { break; }
            }

            if (stack.Contains(hasElement))
            {
                Console.WriteLine("true");
            }
            else if (stack.Any())
            {
                var smallest = stack.Min();
                Console.WriteLine(smallest);
            }
            else
            {
                Console.WriteLine("0");
            }
        }
    }
}
