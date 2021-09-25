using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Strategy
{
    public class StrategyApproach
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

        interface IQuack
        {
            void Quack();
        }

        interface IFly
        {
            void Fly();
        }

        class QuackDuck : IQuack
        {
            public void Quack()
            {
                Console.WriteLine("Quack! Quack!");
            }
        }

        class SquickDuck : IQuack
        {
            public void Quack()
            {
                Console.WriteLine("Squick! Squick!");
            }
        }

        class NoSoundDuck : IQuack
        {
            public void Quack()
            {
                Console.WriteLine("This duck has no sound");
            }
        }

        class FlyDuck : IFly
        {
            public void Fly()
            {
                Console.WriteLine("Duck is flying");
            }
        }

        class NoFlyDuck : IFly
        {
            public void Fly()
            {
                Console.WriteLine("This Duck can't fly");
            }
        }

        abstract class Duck
        {
            private IFly _fly;
            private IQuack _quack;

            public Duck(IFly fly, IQuack quack)
            {
                _fly = fly;
                _quack = quack;
            }

            public abstract void Display();

            public void Swim()
            {
                Console.WriteLine("Duck is swimming");
            }

            public void Quack()
            {
                _quack.Quack();
            }

            public void Fly()
            {
                _fly.Fly();
            }
        }

        class RegularDuck : Duck
        {
            public RegularDuck() : base(new FlyDuck(), new QuackDuck())
            {
            }

            public override void Display()
            {
                Console.WriteLine("This is a Regular Duck");
            }
        }

        class DonaldDuck : Duck
        {
            public DonaldDuck() : base(new FlyDuck(), new QuackDuck())
            {
            }

            public override void Display()
            {
                Console.WriteLine("This is a Donald Duck");
            }
        }

        class RubberDuck : Duck
        {
            public RubberDuck() : base(new NoFlyDuck(), new SquickDuck())
            {
            }

            public override void Display()
            {
                Console.WriteLine("This is a Rubber Duck");
            }
        }

        class DecoyDuck : Duck
        {
            public DecoyDuck() : base(new NoFlyDuck(), new NoSoundDuck())
            {
            }

            public override void Display()
            {
                Console.WriteLine("This is a Decoy Duck");
            }            
        }

    }
}
