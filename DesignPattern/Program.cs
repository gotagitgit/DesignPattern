using DesignPattern.Builder;
using DesignPattern.Decorator;
//using DesignPattern.Factory;
using DesignPattern.Strategy;
using DesignPattern.Visitor.NoVisitor;
using DesignPattern.Visitor.WithVisitor;
using System;

namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // Factory Pattern
            //NoFactoryApproach.Run();
            //FactoryPatternApproach.Run();

            // Strategy Pattern

            //var inheritanceApproach = new InheritanceApproach();
            //inheritanceApproach.Run();

            //var interfaceApproach = new IntefaceApproach();
            //interfaceApproach.Run();

            //var strategyApproach = new StrategyApproach();
            //strategyApproach.Run();

            // Decorator Pattern

            //var inheritanceApproach = new DecoratorPatternInheritanceApproach();
            //inheritanceApproach.Run();

            //var decoratorApproach = new DecoratorApproach();
            //decoratorApproach.Run();

            // Builder Pattern

            //var person1 = new Person("Juan");
            //var person2 = new Person("John", "Doe");

            //var personBuilder = new PersonBuilder();

            //var person3 = personBuilder.WithFirstName("Juan")
            //                            .WithLastName("Dela Crue")
            //                            .WithAge(18)
            //                            .Build();

            //Console.WriteLine($"Hi I'm {person1.FirstName} {person1.LastName}.  I'm {person1.Age} years old.");
            //Console.WriteLine($"Hi I'm {person2.FirstName} {person2.LastName}.  I'm {person2.Age} years old.");
            //Console.WriteLine($"Hi I'm {person3.FirstName} {person3.LastName}.  I'm {person3.Age} years old.");

            // Visitor Pattern
            var noVisitor = new NoVisitorApproach();
            noVisitor.Run();

            //var visitorApproach = new VisitorApproach();
            //visitorApproach.Run();

            Console.ReadLine();
        }
    }
}
