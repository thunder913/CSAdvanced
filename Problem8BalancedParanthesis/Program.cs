using System;
using System.Linq;
using System.Collections.Generic;

namespace Problem8BalancedParanthesis
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputStr = Console.ReadLine();
            var input = new List<char>();
            foreach (var item in inputStr)
            {
                input.Add(item);
            }
            if (input.Count%2!=0)
            {
                Console.WriteLine("NO");
                return;
            }
            for (int i = 0; i < input.Count / 2; i++)
            {
                if (input[0] == '(')
                {
                    if (input.Remove(')')) 
                    {
                        input.Remove('(');
                    }
                }else if (input[0] == '{')
                {
                    if (input.Remove('}'))
                    {
                        input.Remove('}');
                    }
                }else if (input[0] == '[')
                {
                    if (input.Remove(']'))
                    {
                        input.Remove('[');
                    }
                }
                else 
                {
                    Console.WriteLine("NO");
                    return;
                }
            }
            Console.WriteLine("YES");
        }
    }

}
