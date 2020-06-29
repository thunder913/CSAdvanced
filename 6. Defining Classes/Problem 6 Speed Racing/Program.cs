using System;
using System.Collections.Generic;
using System.Linq;
namespace Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            var cars = new List<Car>();
            int inputs = int.Parse(Console.ReadLine());
            for (int i = 0; i < inputs; i++)
            {
                var carDetails = Console.ReadLine().Split().ToList();
                var model = carDetails[0];
                var fuel = double.Parse(carDetails[1]);
                var consumtion = double.Parse(carDetails[2]);
                var newCar = new Car(model, fuel, consumtion);
                cars.Add(newCar);
            }

            var input = Console.ReadLine().Split().ToList();
            while (input[0] != "End")
            {
                var model = input[1];
                var kilometres = double.Parse(input[2]);
                bool canDrive =Car.Drive(cars, model, kilometres);
                if (!canDrive)
                {
                    Console.WriteLine("Insufficient fuel for the drive");
                }

                input = Console.ReadLine().Split().ToList();
            }
            foreach (var car in cars)
            {
                var info = Car.getInfo(car);
                Console.WriteLine($"{info.Item1} {info.Item2:f2} {info.Item3}");
            }
        }
    }
}
