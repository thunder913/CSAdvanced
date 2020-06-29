using System;
using System.Collections.Generic;
using System.Linq;
namespace Problem7
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().ToList();

            var firstTutle = new myTuple<string,string>() {item1 = input[0] + " " + input[1], item2 = input[2] };
            input = Console.ReadLine().Split().ToList();
            var secondTutle = new myTuple<string, int>() { item1 = input[0], item2 = int.Parse(input[1]) };
            input = Console.ReadLine().Split().ToList();
            var thirdTutle = new myTuple<int, double>() { item1 = int.Parse(input[0]), item2 = double.Parse(input[1])};
            Console.WriteLine($"{firstTutle.item1} -> {firstTutle.item2}");
            Console.WriteLine($"{secondTutle.item1} -> {secondTutle.item2}");
            Console.WriteLine($"{thirdTutle.item1} -> {thirdTutle.item2}");
        }
    }
}
