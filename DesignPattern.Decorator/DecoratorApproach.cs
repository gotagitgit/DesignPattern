using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Decorator
{
    public class DecoratorApproach
    {
        public void Run()
        {
            Beverage coffee = new Machiato();
            coffee = new Whip(coffee);            
            coffee = new Whip(coffee);            
            coffee = new Milk(coffee);


            Console.WriteLine(coffee.Description);
            Console.WriteLine(coffee.Cost());
        }

        // Component
        abstract class Beverage
        {
            protected string _description;

            public Beverage()
            {                
            }

            public virtual string Description => _description;

            public abstract double Cost();
        }

        #region Concrete Component

        class Brewed : Beverage
        {
            public Brewed()
            {
                _description = "Mocha";
            }

            public override double Cost()
            {
                return 1.50;
            }
        }

        class Machiato : Beverage
        {
            public Machiato()
            {
                _description = "Machiato";
            }

            public override double Cost()
            {
                return 2.50;
            }
        }

        #endregion

        // Decorator
        abstract class Condiment : Beverage
        {            
        }

        #region Concrete Decorator

        class Whip : Condiment
        {
            private readonly Beverage _beverage;

            public Whip(Beverage beverage)
            {
                _beverage = beverage;
            }

            public override string Description => $"{_beverage.Description}, Whip";

            public override double Cost()
            {
                return _beverage.Cost() + 0.50;
            }
        }

        class Milk : Condiment
        {
            private readonly Beverage _beverage;

            public Milk(Beverage beverage)
            {
                _beverage = beverage;
            }

            public override string Description => $"{_beverage.Description}, Milk";

            public override double Cost()
            {
                return _beverage.Cost() + 0.25;
            }
        }

        #endregion

    }
}
