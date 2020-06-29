using System;
using System.Linq;
namespace Problem_2._Knights_of_Honor
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();
            Action<string> print = w => Console.WriteLine($"Sir {w}");
            foreach (var item in input)
            {
                print(item);
            }
        }
    }
}
