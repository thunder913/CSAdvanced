using System;
using System.Collections.Generic;
using System.Text;

namespace Problem7
{
    class ENgine
    {
        int engineSpeed;
        int enginePower;


        public ENgine(int engineSpeed, int enginePower) 
        {
            this.enginePower = enginePower;
            this.engineSpeed = engineSpeed;
        }

        public static bool EnginePowerOver250(ENgine engine) 
        {
            if (engine.enginePower>250)
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
