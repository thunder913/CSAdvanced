using System;
using System.Linq;
using System.Collections.Generic;

namespace Problem8
{
    class Program
    {
        static void Main(string[] args)
        {
            var engineList = new List<Engine>();
            var carList = new List<Car>();
            var inputs = int.Parse(Console.ReadLine());
            for (int i = 0; i < inputs; i++)
            {
                var engineInfo = Console.ReadLine().Split();
                string model = engineInfo[0];
                string power = engineInfo[1];
                string displacement = "n/a";
                string efficiency = "n/a";
                var engineInfoLen = engineInfo.Length;
                if (engineInfoLen == 4)
                {
                    displacement = engineInfo[2];
                    efficiency = engineInfo[3];
                }
                else if (engineInfoLen == 3)
                {
                    if (int.TryParse(engineInfo[2], out int test))
                    {
                        displacement = engineInfo[2];
                    }
                    else 
                    {
                        efficiency = engineInfo[2];
                    }
                }
                Engine engine = new Engine(model, power, displacement, efficiency);
                engineList.Add(engine);
            }
            inputs = int.Parse(Console.ReadLine());
            for (int i = 0; i < inputs; i++)
            {
                var carInfo = Console.ReadLine().Split(new char[] { ' '}, StringSplitOptions.RemoveEmptyEntries);
                string model = carInfo[0];
                string engine = carInfo[1];
                var carInfoDetails = carInfo.Length;
                string weight = "n/a";
                string color = "n/a";
                if (carInfoDetails == 4)
                {   
                    weight = carInfo[2];
                    color = carInfo[3];
                }
                else if (carInfoDetails==3)
                {
                    if (int.TryParse(carInfo[2], out int test))
                    {
                        weight = carInfo[2];
                    }
                    else 
                    {
                        color = carInfo[2];
                    }
                }
                foreach (var item in engineList)
                {
                    var currentEngine = item.isTheSameEngine(engine, item);
                    if (currentEngine.Item1 == false)
                    {
                        goto Start;
                    }
                    bool isItSafe = currentEngine.Item1;
                    string engineModel = currentEngine.Item2;
                    string power = currentEngine.Item3;
                    string displacement = currentEngine.Item4;
                    string efficiency = currentEngine.Item5;
                    var currentCarEngine = new Engine(engineModel, power, displacement, efficiency);
                    Car currentCar = new Car(model, currentCarEngine, weight, color);
                    carList.Add(currentCar);
                Start:;
                }
            }

            foreach (var car in carList)
            {
                Console.WriteLine(car.ToString());
            }
        }
    }
}
