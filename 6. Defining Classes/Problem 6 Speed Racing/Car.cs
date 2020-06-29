using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Problem
{
    class Car
    {
        string model;
        double fuelAmount;
        double fuelConsumationPerKilometer;
        double TravelledDistance = 0;


        public Car(string model, double fuel, double consumation) 
        {
            this.model = model;
            this.fuelAmount = fuel;
            this.fuelConsumationPerKilometer = consumation;
        }

        public static bool Drive(List<Car> cars, string carModel, double kilometres)
        {
            Car currentCar = cars.First(x => x.model == carModel);
            int index = cars.IndexOf(currentCar);
            double fuelNeeded = cars[index].fuelConsumationPerKilometer * kilometres;
            if (fuelNeeded > cars[index].fuelAmount)
            {
                return false;
            }
            else 
            {
                cars[index].TravelledDistance += kilometres;
                cars[index].fuelAmount -= fuelNeeded;
                return true;
            }
        }

        public static (string, double, double) getInfo(Car car) 
        {
            return (car.model, car.fuelAmount, car.TravelledDistance);
        }
    }
}
