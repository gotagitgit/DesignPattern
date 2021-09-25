using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Visitor.WithVisitor
{
    public class CarPartVisitor : ICarVisitor
    {
        private string _engineDetails;
        private string _carDetails;
        private int _seatsCount;

        public string GetCarDescription()
        {
            return $"{_carDetails} {_engineDetails} {_seatsCount} seat(s)";
        }       

        public void Visit(Engine engine)
        {
            _engineDetails = $"{engine.CylinderVolume}cc {engine.Power}kW";
        }

        public void Visit(Seat seat)
        {
            _seatsCount += seat.Capacity;
        }

        public void VisitCar(string make, string model)
        {
            _carDetails =  $"{make} {model}";
        }
    }
}
