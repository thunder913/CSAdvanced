using System;
using System.Linq;
using System.Collections.Generic;
namespace Problem3
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<Data<int>>();
            var inputs = int.Parse(Console.ReadLine());
            for (int i = 0; i < inputs; i++)
            {
                var input = int.Parse(Console.ReadLine());
                list.Add(new Data<int>() { item = input });
            }

            var toSwap = Console.ReadLine().Split().Select(int.Parse).ToArray();
            list[0].SwapIndexes(list, toSwap[0], toSwap[1]);
            for (int i = 0; i < inputs; i++)
            {
                Console.WriteLine(list[i].ToString());
            }
        }

        

    }
}
