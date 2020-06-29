using System;
using System.Linq;
namespace Problem_6._Reverse_and_Exclude
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int numToSubs = int.Parse(Console.ReadLine());
            numbers = numbers.Where(x => x % numToSubs != 0).Reverse().ToList();
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
