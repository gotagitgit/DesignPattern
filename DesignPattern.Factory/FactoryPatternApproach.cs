using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern.Factory
{
    public class FactoryPatternApproach
    {
        public static void Run()
        {
            var automobileFactory = new AutomobileFactory();

            var autoType = AutomobileType.Car;

            var automobile = automobileFactory.Create(autoType);

            Console.WriteLine($"{automobile.Name} has {automobile.WheelCount} wheels!");
        }

        class AutomobileFactory
        {
            private readonly IDictionary<AutomobileType, IAutomobile> _automobiles;

            public AutomobileFactory()
            {
                _automobiles = GetAutomobiles();
            }
            
            private static IDictionary<AutomobileType, IAutomobile> GetAutomobiles()
            {
                var automobiles = new List<IAutomobile>
                {
                    new Car(),
                    new Bike(),
                    new Tricycle()
                };

                return automobiles.ToDictionary(x => x.Type, x => x);
            }

            public IAutomobile Create(AutomobileType type)
            {
                if (!_automobiles.TryGetValue(type, out var automobile))
                    throw new Exception("Automobile does not exists!");

                return automobile;
            }
        }

        enum AutomobileType
        {
            Bike,
            Tricycle,
            Car
        }

        interface IAutomobile
        {
            string Name { get; }
            AutomobileType Type { get; }
            int WheelCount { get; }
        }

        class Car : IAutomobile
        {
            public AutomobileType Type => AutomobileType.Car;

            public string Name => "Car";

            public int WheelCount => 4;
        }

        class Bike : IAutomobile
        {
            public string Name => "Bicycle";

            public AutomobileType Type => AutomobileType.Bike;

            public int WheelCount => 3;
        }

        class Tricycle : IAutomobile
        {
            public string Name => "Pedicab";

            public AutomobileType Type => AutomobileType.Tricycle;

            public int WheelCount => 3;
        }
    }
}
