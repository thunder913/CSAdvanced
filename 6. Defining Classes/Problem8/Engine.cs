using System;
using System.Collections.Generic;
using System.Text;

namespace Problem8
{
    class Engine
    {
        string model { get; set; }
        string power { get; set; }
        string displacement { get; set; }
        string efficiency {get;set;}

        public Engine(string Model, string Power, string Dispacement, string Efficiency) 
        {
            this.model = Model;
            this.power = Power;
            this.displacement = Dispacement;
            this.efficiency = Efficiency;
        }

        public string GetPower() 
        {
            return this.power;
        }
        public string GetEngineModel()
        {
            return this.model;
        }
        public string GetDispacement()
        {
            return this.displacement;
        }
        public string GetEfficiency()
        {
            return this.efficiency;
        }
        public (bool, string,string,string,string) isTheSameEngine(string engineName, Engine currentEngine) 
        {
            while (true)
            {
                if (currentEngine.model == engineName)
                {
                    return (true, this.model, this.power, this.displacement, this.efficiency);
                }
                else
                {
                    return (false, this.model, this.power, this.displacement, this.efficiency);
                }
            }
        }
    }
}
