using System;
using System.Collections.Generic;
using System.Linq;
namespace Problem_6.__Songs_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            var startingSongs = Console.ReadLine().Split(", ");
            var queue = new Queue<string>(startingSongs);
            while (queue.Any())
            {
                string command = Console.ReadLine();
                if (command == "Play")
                {
                    queue.Dequeue();
                }
                else if (command == "Show")
                {
                    Console.WriteLine(string.Join(", ", queue));
                }
                else
                { 
                    var commandAdd = command.Substring(4);
                    if (!queue.Contains(commandAdd))
                    {
                        queue.Enqueue(commandAdd);
                    }
                    else 
                    {
                        Console.WriteLine($"{commandAdd} is already contained!");
                    }
                }
            }
            Console.WriteLine("No more songs!");
        }
    }
}
