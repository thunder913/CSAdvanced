using System;
using System.Collections.Generic;
using System.Linq;
namespace Problem8._1
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            var even = numbers.Where(x => x % 2 == 0).OrderBy(x=>x);
            var odd = numbers.Where(x => x % 2 != 0).OrderBy(x=>x);
            Console.Write(string.Join(" ", even));
            Console.Write(" ");
            Console.WriteLine(string.Join(" ", odd));
        }
    }
}
