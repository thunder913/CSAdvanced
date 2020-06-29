using System;
using System.Linq;
using System.Collections.Generic;
namespace Problem7
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            var inputCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < inputCount; i++)
            {
                var carInfo = Console.ReadLine().Split();
                string model = carInfo[0];
                int engineSpeed = int.Parse(carInfo[1]);
                int enginePower = int.Parse(carInfo[2]);
                int cargoWeigt = int.Parse(carInfo[3]);
                string cargoType = carInfo[4];
                double tire1Pressure = double.Parse(carInfo[5]);
                int tire1Age = int.Parse(carInfo[6]);
                double tire2Pressure = double.Parse(carInfo[7]);
                int tire2Age = int.Parse(carInfo[8]);
                double tire3Pressure = double.Parse(carInfo[9]);
                int tire3Age = int.Parse(carInfo[10]);
                double tire4Pressure = double.Parse(carInfo[11]);
                int tire4Age = int.Parse(carInfo[12]);
                var car = Car.AddCar(model, engineSpeed, enginePower, cargoWeigt, cargoType, tire1Pressure, tire1Age, tire2Pressure, tire2Age, tire3Pressure, tire3Age, tire4Pressure, tire4Age);
                cars.Add(car);
            }
            var command = Console.ReadLine();
            if (command == "fragile")
            {
                foreach (var car in cars)
                {
                    bool isFragileandTire = Car.isFragileAndTirePressureUnder1(car);
                    if (isFragileandTire)
                    {
                        Console.WriteLine($"{Car.getName(car)}");
                    }
                }
            }
            else 
            {
                foreach (var car in cars)
                {
                    bool isFlammableAndEngine = Car.isFlammableAndEnginePowerOver250(car);
                    if (isFlammableAndEngine)
                    {
                        Console.WriteLine($"{Car.getName(car)}");
                    }
                }
            }
        }
    }
}
