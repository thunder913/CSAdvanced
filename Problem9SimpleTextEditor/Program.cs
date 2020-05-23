using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Problem9SimpleTextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            var sb = new StringBuilder();
            var inputs = int.Parse(Console.ReadLine());
            var history = new Stack<string>();
            for (int i = 0; i < inputs; i++)
            {
                var command = Console.ReadLine().Split(" ").ToArray();

                switch (command[0])
                {
                    case "1":
                        history.Push(sb.ToString());
                        sb.Append(command[1]);
                        break;
                    case "2":
                        history.Push(sb.ToString());
                        sb.Remove(sb.Length - int.Parse(command[1]), int.Parse(command[1]));
                        break;
                    case "3":
                        Console.WriteLine($"{sb[int.Parse(command[1]) - 1]}");
                        break;
                    case "4":
                        sb.Clear();
                        sb.Append(history.Pop());
                        break;
                }
            }
        }
    }
}
