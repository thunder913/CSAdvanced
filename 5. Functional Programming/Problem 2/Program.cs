using System;
using System.Linq;
using System.Collections.Generic;
namespace Problem_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxNum = int.Parse(Console.ReadLine());
            var divirsibleList = Console.ReadLine().Split().Select(int.Parse).ToList();
            int numberToDivirse = 1;
            var list = new List<int>();
            foreach (var item in divirsibleList)
            {
                if (!list.Contains(item))
                {
                    list.Add(item);
                    numberToDivirse *= item;
                }
            }
            for (int i = 1; i <= maxNum; i++)
            {
                if (i % numberToDivirse == 0)
                {
                    Console.Write(i + " ");
                }
            }
            var printList = new List<int>();
            
        }
    }
}
