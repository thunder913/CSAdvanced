using System;
using System.Linq;

namespace Problem_3._Custom_Min_Function
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Func<int[], int> func = num => 
            {
                return num.Min();
            };
            Console.WriteLine(func(numbers));
            
        }

    }

}