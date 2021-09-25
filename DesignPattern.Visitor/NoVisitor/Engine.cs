using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Visitor.NoVisitor
{
    public class Engine
    {
        public Engine(float power, float cylinderVolume)
        {
            Power = power;
            CylinderVolume = cylinderVolume;
        }

        public float Power { get; private set; }
        public float CylinderVolume { get; private set; }
    }
}
