using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Strategy
{
    public class IntefaceApproach
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
                _duck.Swim();

                if (_duck is IFly flyDuck)
                    flyDuck.Fly();

                if (_duck is IQuack quackDuck)
                    quackDuck.Quack();

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

        abstract class Duck
        {
            public abstract void Display();

            public void Swim()
            {
                Console.WriteLine("Duck is swimming");
            }
        }

        class RegularDuck : Duck, IQuack, IFly
        {
            public override void Display()
            {
                Console.WriteLine("This is a Regular Duck");
            }

            public void Fly()
            {
                Console.WriteLine("Duck is flying");
            }

            public void Quack()
            {
                Console.WriteLine("Quack! Quack!");
            }
        }

        class DonaldDuck : Duck, IQuack, IFly
        {
            public override void Display()
            {
                Console.WriteLine("This is a Donald Duck");
            }

            public void Fly()
            {
                Console.WriteLine("Duck is flying");
            }

            public void Quack()
            {
                Console.WriteLine("Quack! Quack!");
            }
        }

        class RubberDuck : Duck, IQuack
        {
            public override void Display()
            {
                Console.WriteLine("This is a Rubber Duck");
            }

            public void Quack()
            {
                Console.WriteLine("Squick! Squick!");
            }
        }

        class DecoyDuck : Duck
        {
            public override void Display()
            {
                Console.WriteLine("This is a Decoy Duck");
            }
        }
    }
}
