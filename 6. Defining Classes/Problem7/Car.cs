using System;
using System.Collections.Generic;
using System.Text;

namespace Problem7
{
    class Car
    {
        string model;
        ENgine engine;
        Cargo cargo;
        Tire tire;



        public static Car AddCar(string model,
        int engineSpeed,
        int enginePower,
        int cargoWeigt,
        string cargoType,
        double tire1Pressure,
        int tire1Age,
        double tire2Pressure,
        int tire2Age,
        double tire3Pressure,
        int tire3Age,
        double tire4Pressure,
        int tire4Age
        )
        {
            Car newCar = new Car(model);
            ENgine engine = new ENgine(engineSpeed, enginePower);
            Cargo cargo = new Cargo(cargoWeigt, cargoType);
            Tire tire = new Tire(tire1Pressure, tire1Age, tire2Pressure, tire2Age, tire3Pressure, tire3Age, tire4Pressure, tire4Age);
            newCar.engine = engine;
            newCar.cargo = cargo;
            newCar.tire = tire;
            return newCar;
        }

        public Car(string model) 
        {
            this.model = model;
        }
        public static bool isFragileAndTirePressureUnder1(Car currentCar) 
        {
            bool isFragile = Cargo.isFragileOrFlammable(currentCar.cargo);
            bool hasEnoughPressure = Tire.hasPressure(currentCar.tire);
            return isFragile && hasEnoughPressure;
        }

        public static bool isFlammableAndEnginePowerOver250(Car currentCar) 
        {
            bool isFragile = Cargo.isFragileOrFlammable(currentCar.cargo);
            bool hasEnginePowerOver250 = ENgine.EnginePowerOver250(currentCar.engine);
            if (isFragile == false && hasEnginePowerOver250)
            {
                return true;
            }
            else 
            {
                return false;
            }
                
        }

        public static string getName(Car currentCar) 
        {
            return currentCar.model;
        }
    }

}
