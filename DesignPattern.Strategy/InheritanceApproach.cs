using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Strategy
{
    public class InheritanceApproach
    {
        public void Run()
        {
            var context = new Context(new RegularDuck());
            context.DoDuckStuff();

            context = new Context(new DonaldDuck());
            context.DoDuckStuff();

            context = new Context(new RubberDuck());
            context.DoDuckStuff();

            context = new Context(new DecoyDuck());
            context.DoDuckStuff();
        }

        class Context
        {
            private Duck _duck;

            public Context(Duck duck)
            {
                _duck = duck;
            }

            public void DoDuckStuff()
            {
                _duck.Display();                
                _duck.Quack();                
                _duck.Swim();                
                _duck.Fly();
                Console.WriteLine("\n\n");
            }
        }

        abstract class Duck
        {
            public abstract void Display();

            public virtual void Quack()
            {
                Console.WriteLine("Quack! Quack!");
            }

            public void Swim()
            {
                Console.WriteLine("Duck is swimming");
            }

            // New Feature
            public virtual void Fly()
            {
                Console.WriteLine("Duck is flying");
            }
        }

        class RegularDuck : Duck
        {
            public override void Display()
            {
                Console.WriteLine("This is a Regular Duck");
            }
        }

        class DonaldDuck : Duck
        {
            public override void Display()
            {
                Console.WriteLine("This is a Donald Duck");
            }
        }

        class RubberDuck : Duck
        {
            public override void Display()
            {
                Console.WriteLine("This is a Rubber Duck");
            }

            public override void Quack()
            {
                Console.WriteLine("Squick! Squick!");
            }

            public override void Fly()
            {
                // Do nothing
            }
        }

        class DecoyDuck : Duck
        {
            public override void Display()
            {
                Console.WriteLine("This is a Decoy Duck");
            }

            public override void Quack()
            {
                // Do nothing
            }

            public override void Fly()
            {
                // Do nothing
            }
        }
    }    
}
