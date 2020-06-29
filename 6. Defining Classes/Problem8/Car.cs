using System;
using System.Collections.Generic;
using System.Text;

namespace Problem8
{
    class Car
    {
        string model;
        Engine engine;
        string weight;
        string color;

        public Car(string model,
        Engine engine,
        string weight,
        string color)
        {
            this.engine = engine;
            this.model = model;
            this.weight = weight;
            this.color = color;

        }
        public override string ToString()
        {
            Engine engine = this.engine;
            return $"{this.model}:\n  {engine.GetEngineModel()}:\n    Power: {engine.GetPower()}\n    Displacement: {engine.GetDispacement()}\n    Efficiency: {engine.GetEfficiency()}\n  Weight: {this.weight}\n  Color: { this.color}";
        }
    }
}
