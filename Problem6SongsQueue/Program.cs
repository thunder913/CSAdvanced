using System;
using System.Collections.Generic;
using System.Linq;
namespace Problem6SongsQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstSongs = Console.ReadLine().Split(", ");
            var queue = new Queue<string>(firstSongs);

            while (true)
            {
                var input = Console.ReadLine().Split();
                if (input[0] == "Add")
                {
                    string songName = input[1];
                    for (int i = 2; i < input.Length; i++)
                    {
                        songName += " " + input[i];
                    }
                    if (!queue.Contains(songName))
                    {
                        queue.Enqueue(songName);
                    }
                    else 
                    {
                        Console.WriteLine($"{songName} is already contained!");
                    }
                }
                else if (input[0] == "Play")
                {
                    if (queue.Any())
                    {
                        queue.Dequeue();
                    }
                }
                else if (input[0] == "Show")
                {
                    Console.WriteLine(string.Join(", ", queue)); 
                }

                if (!queue.Any())
                {
                    Console.WriteLine($"No more songs!");
                    return;
                }
            }
        }
    }
}
