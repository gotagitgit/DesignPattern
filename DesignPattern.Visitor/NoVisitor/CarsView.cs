using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern.Visitor.NoVisitor
{
    internal class CarsView
    {
        private IEnumerable<Car> _cars;

        public CarsView(IEnumerable<Car> cars)
        {
            _cars = cars;
        }

        public void Render()
        {
            foreach (var car in _cars)
            {
                // Force the view to calculate the number of seats which should be in domain logic
                var seatCount = car.Seats.Sum(x => x.Capacity);

                Console.WriteLine($"{car.Make} {car.Model}, {car.Engine.CylinderVolume}cc {car.Engine.Power}kW {seatCount} seat(s)");
            }
        }
    }
}
