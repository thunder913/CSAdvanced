using System;
using System.Linq;
using System.Collections.Generic;
namespace Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputs = int.Parse(Console.ReadLine());
            var box = new List<Box<int>>();
            for (int i = 0; i < inputs; i++)
            {
                var input = int.Parse(Console.ReadLine());
                var newBox = new Box<int>();
                newBox.Add(input);
                box.Add(newBox);
            }

            for (int i = 0; i < inputs; i++)
            {
                Console.WriteLine(box[i].ToString());
            }
        }
    }
}
