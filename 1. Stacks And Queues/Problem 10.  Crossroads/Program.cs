using System;
using System.Collections.Generic;
using System.Linq;
namespace Problem_10.__Crossroads
{
    class Program
    {
        static void Main(string[] args)
        {
            int carCount = 0;
            bool hasCrash = false;
            var queue = new Queue<string>();
            int greenTime = int.Parse(Console.ReadLine());
            int timeToLeave = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            while (input!= "END")
            {
                if (input != "green")
                {
                    queue.Enqueue(input);
                }
                else
                {
                    string car = "";
                    int carIn = 0;
                    for (int i=0; i < greenTime && queue.Any();)
                    {
                        carCount++;
                        car = queue.Dequeue();
                        i += car.Length;
                        if (i > greenTime)
                        {
                            carIn = i - greenTime;
                        }
                    }
                    if (carIn > timeToLeave)
                    {
                        hasCrash = true;
                        Console.WriteLine("A crash happened!");
                        
                        Console.WriteLine($"{car} was hit at {car[car.Length - (carIn-timeToLeave)]}.");
                        break;
                    }
                }
                input = Console.ReadLine();
            }
            if (!hasCrash)
            {
                Console.WriteLine("Everyone is safe.");
                Console.WriteLine($"{carCount} total cars passed the crossroads.");
            }
        }
    }
}
