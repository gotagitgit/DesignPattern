using System;

namespace DesignPattern.Factory
{
    public class NoFactoryApproach
    {
        public static void Run()
        {
            var autoType = AutomobileType.Car;

            switch (autoType)
            {
                case AutomobileType.Bike:
                    var bike = new Bike();
                   
                    Console.WriteLine($"Bike has { bike.GetNumberOfWheels()} wheels!");
                    break;

                case AutomobileType.Tricycle:
                    var tricyCle = new Tricycle();

                    Console.WriteLine($"Tricycle has { tricyCle.GetNumberOfWheels()} wheels!");
                    break;

                case AutomobileType.Car:
                    var car = new Car();
                   
                    Console.WriteLine($"Car has {car.GetNumberOfWheels()} wheels!");
                    break;

                default:
                    break;
            }          
        }

        enum AutomobileType
        {
            Bike,
            Tricycle,
            Car
        }

        class Car
        {
            public int GetNumberOfWheels() => 4;
        }

        class Tricycle
        {
            public int GetNumberOfWheels() => 3;
        }

        class Bike
        {
            public int GetNumberOfWheels() => 2;
        }
    }
}
