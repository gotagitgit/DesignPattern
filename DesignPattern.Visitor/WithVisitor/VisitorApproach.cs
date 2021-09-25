using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Visitor.WithVisitor
{
    public class VisitorApproach
    {
        public void Run()
        {
            var carRepository = new CarsRepository();

            var carsView = new CarsView(carRepository.GetAll());

            carsView.Render();

        }
    }
}
