using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Visitor.WithVisitor
{
    public class CarRegistration
    {
        private readonly string _make;
        private readonly string _model;
        private readonly float _capacity;
        private readonly int _maxPassengers;

        public CarRegistration(string make, string model, float capacity, int maxPassengers)
        {
            this._make = make;
            _model = model;
            _capacity = capacity;
            _maxPassengers = maxPassengers;
        }

        public override string ToString()
        {
            return $"{_make} {_model} {_capacity}cc {_maxPassengers} passengers";
        }
    }
}
