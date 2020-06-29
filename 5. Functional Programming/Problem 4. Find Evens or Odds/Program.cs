using System;
using System.Linq;
using System.Collections.Generic;
namespace Problem_4._Find_Evens_or_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            var limits = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int down = limits[0];
            int up = limits[1];
            int[] arr = { 1, 2, 3, 4 };
            var oddOrEven = Console.ReadLine();
            Func<int, int, string, List<int>> func = (low, high, oddOrEven) =>
             {
                 var numbers = new List<int>();
                 for (int i = low; i <= high; i++)
                 {

                     if (oddOrEven == "odd" && i % 2 != 0)
                     {
                         numbers.Add(i);
                     }
                     else if (oddOrEven == "even" && i % 2 == 0)
                     {
                         numbers.Add(i);
                     }
                 }
                 return numbers;
             };
            Print(func(down, up, oddOrEven));
        }

        public static void Print(List<int> numbers)
        {
            Console.WriteLine(string.Join(" ", numbers));
        }

        int a(int x, int y) => x * y;
    }
}

