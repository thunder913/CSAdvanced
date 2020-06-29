using System;
using System.Linq;

namespace Functional_Programming
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();
            Action<string> print = word => Console.WriteLine(word);
            foreach (var item in input)
            {
                print(item);
            }
        }
    }
}
