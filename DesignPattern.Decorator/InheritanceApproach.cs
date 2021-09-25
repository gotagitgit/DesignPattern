using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Decorator
{
    public class DecoratorPatternInheritanceApproach
    {
        public void Run()
        {
            Beverage coffee = new Machiato();
            coffee.SetWhip();
            coffee.SetMilk();

            Console.WriteLine(coffee.Description);
            Console.WriteLine(coffee.Cost());
        }

        abstract class Beverage
        {
            protected string _description;

            public Beverage()
            {
                HasMilk = false;
                HasWhip = false;
            }

            public virtual string Description => _description;

            public abstract double Cost();

            public bool HasMilk { get; private set; }

            public bool HasWhip { get; private set; }

            public void SetMilk()
            {
                _description += ", Milk";
                HasMilk = true;
            }

            public void SetWhip()
            {
                _description += ", Whip";
                HasWhip = true;
            }

            protected double ComputeCondiments(double cost)
            {
                var computedCost = cost;

                if (HasWhip)
                    computedCost += 0.50;

                if (HasMilk)
                    computedCost += 0.25;

                return computedCost;
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
                return ComputeCondiments(2.50);
            }
        }

        class Brewed : Beverage
        {
            public Brewed()
            {
                _description = "Brewed";
            }

            public override double Cost()
            {   
                return ComputeCondiments(1.50); 
            }
        }
    }
}
