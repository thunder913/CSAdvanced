using System;
using System.Linq;
using System.Collections.Generic;
namespace Problem_5._Applied_Arithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            var command = Console.ReadLine();
            
            while (command != "end")
            {
                
                Func<List<int>, List<int>> func = command switch
                {
                "add" => n => n.Select(x => ++x).ToList(),
                "multiply" => n => n.Select(x => x *= 2).ToList(),
                "subtract" => n => n.Select(x => x -= 1).ToList(),
                "print" => n =>
                    {
                        Console.WriteLine(string.Join(" ", n));
                        return n;
                    },
                _ => n=> n,
                };

                numbers = func(numbers).ToList();
            command = Console.ReadLine();
            }
        }
    }
}
