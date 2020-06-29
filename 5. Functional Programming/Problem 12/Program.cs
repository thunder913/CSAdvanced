using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, int, bool> func = (s, i) => s.Sum(x=> x) >= i;
            int num = int.Parse(Console.ReadLine());
            var names = Console.ReadLine().Split();
            foreach (var item in names)
            {
                if (func(item,num))
                {
                    Console.WriteLine(item);
                    break;
                }
            }
        }
    }
}
