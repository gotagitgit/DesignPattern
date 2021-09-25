using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignPattern.Visitor.WithVisitor
{
    public class Car
    {
        private readonly string _make;
        private readonly string _model;
        private readonly Engine _engine;
        private readonly IEnumerable<Seat> _seats;

        public Car(string make, string model, Engine engine, IEnumerable<Seat> seats)
        {
            _make = make;
            _model = model;
            _engine = engine;
            _seats = seats;
        }

        public CarRegistration Register()
        {
            return new CarRegistration(_make.ToUpper(), _model, _engine.CylinderVolume, _seats.Sum(x => x.Capacity));
        }

        public void Accept(ICarVisitor visitor)
        {
            visitor.VisitCar(_make, _model);

            foreach (var seat in _seats)
            {
                seat.Accept(visitor);
            }

            _engine.Accept(visitor);

            
        }
    }
}
