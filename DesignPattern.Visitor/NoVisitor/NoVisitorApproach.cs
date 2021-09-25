using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Visitor.NoVisitor
{
    public class NoVisitorApproach
    {
        public void Run()
        {
            var carRepository = new CarsRepository();

            var carsView = new CarsView(carRepository.GetAll());

            carsView.Render();

            // Registering two Identical Cars

            Console.WriteLine("Registering same car with only slight difference in name");
            var car1 = new Car("Renault", "Megane", new Engine(66, 1598), Seat.FourSeatConfiguration);

            var carRegistration = car1.Register();

            Console.WriteLine(carRegistration);


            var sameCarRegistration = new CarRegistration("renault", "Megane", 1598, 4);

            Console.WriteLine(sameCarRegistration);

        }
    }
}
