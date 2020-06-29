using System;
using System.Collections.Generic;
using System.Linq;

namespace DateTimeName
{
    class Program
    {
        static void Main(string[] args)
        {
            List<DateTime> list = new List<DateTime>();
            int totalInput = 2;
            for (int i = 0; i < totalInput; i++)
            {
                List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();
                DateTime date = new DateTime(input[0], input[1], input[2]);
                list.Add(date);
            }
            var test = list[0];
            var test2 = list[1];
            Console.WriteLine(Math.Abs((test2 - test).TotalDays));
        }
    }
}
