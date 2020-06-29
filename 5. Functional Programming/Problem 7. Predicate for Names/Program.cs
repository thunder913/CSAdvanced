using System;
using System.Linq;
using System.Collections.Generic;
namespace Problem_7._Predicate_for_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            bool hasBroken = false;
            var printLinst = new List<int>();
            int maxNum = int.Parse(Console.ReadLine());
            var list = Console.ReadLine().Split().Select(int.Parse).ToList();
            for (int i = 1; i <= maxNum; i++)
            {
                foreach (var item in list)
                {
                    if (i % item != 0)
                    {
                        hasBroken = true;
                        break;
                    }
                }
                if (hasBroken)
                {
                    hasBroken = false;
                }
                else
                {
                    printLinst.Add(i);
                }

            }

            Console.WriteLine(string.Join(" ", printLinst));
        }
    }
}
