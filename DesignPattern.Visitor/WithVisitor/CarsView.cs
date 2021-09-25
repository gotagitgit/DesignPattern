using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern.Visitor.WithVisitor
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
                var visitor = new CarPartVisitor();
                car.Accept(visitor);
                Console.WriteLine(visitor.GetCarDescription());
            }
        }
    }
}
