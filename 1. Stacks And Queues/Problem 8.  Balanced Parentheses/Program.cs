using System;
using System.Collections.Generic;
using System.Linq;
namespace Problem_8.__Balanced_Parentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            bool isBalanced = true;
            var stack = new Stack<char>(input);

            foreach (var item in input)
            {
                if (stack.Peek() == item - 2 || stack.Peek() == item + 1 || stack.Peek() == item - 1 || stack.Peek() == item + 2)
                {
                    stack.Pop();
                }
                else 
                {
                    isBalanced = false;
                    break;
                }
            }
            if (isBalanced && stack.Count == 0)
            {
                Console.WriteLine("YES");
            }
            else 
            {
                Console.WriteLine("NO");
            }
        }
    }
}
