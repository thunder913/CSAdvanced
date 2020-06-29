using System;
using System.Collections.Generic;
using System.Text;

namespace Problem7
{
    class Tire
    {
        double tire1Pressure;
        int tire1Age;
        double tire2Pressure;
        int tire2Age;
        double tire3Pressure;
        int tire3Age;
        double tire4Pressure;
        int tire4Age;
        public Tire(double tire1Pressure,
    int tire1Age,
    double tire2Pressure,
    int tire2Age,
    double tire3Pressure,
    int tire3Age,
    double tire4Pressure,
    int tire4Age)
        {
            this.tire1Pressure = tire1Pressure;
            this.tire2Pressure = tire2Pressure;
            this.tire3Pressure = tire3Pressure;
            this.tire4Pressure = tire4Pressure;
            this.tire1Age = tire1Age;
            this.tire2Age = tire2Age;
            this.tire3Age = tire3Age;
            this.tire4Age = tire4Age;
        }

        public static bool hasPressure(Tire tire)
        {
            if (tire.tire1Pressure < 1 || tire.tire2Pressure < 1 || tire.tire3Pressure < 1 || tire.tire4Pressure < 1)
            {
                return true;
            }
            else 
            {
                return false;
            }
        }
    }
}
