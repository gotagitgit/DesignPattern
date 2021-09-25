using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignPattern.Visitor.NoVisitor
{
    public class Car
    {
        public Car(string make, string model, Engine engine, IEnumerable<Seat> seats)
        {
            Make = make;
            Model = model;
            Engine = engine;
            Seats = seats;
        }

        public string Make { get; private set; }
        public string Model { get; private set; }
        public Engine Engine { get; private set; }
        public IEnumerable<Seat> Seats { get; private set; }

        public CarRegistration Register()
        {
            return new CarRegistration(Make.ToUpper(), Model, Engine.CylinderVolume, Seats.Sum(x => x.Capacity));
        }
    }
}
