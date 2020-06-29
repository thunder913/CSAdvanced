using System;
using System.Collections.Generic;
using System.Text;

namespace Problem7
{
    class Cargo
    {
        int cargoWeigt;
        string cargoType;

        public Cargo(int cargoWeigt, string cargoType) 
        {
            this.cargoType = cargoType;
            this.cargoWeigt = cargoWeigt;
        }

        public static bool isFragileOrFlammable(Cargo cargo) 
        {
            if (cargo.cargoType == "fragile")
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
