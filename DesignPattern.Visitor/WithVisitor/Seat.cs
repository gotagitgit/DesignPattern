using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Visitor.WithVisitor
{
    public class Seat
    {
        public Seat(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
        }

        public string Name { get; private set; }
        public int Capacity { get; private set; }

        public static IEnumerable<Seat> FourSeatConfiguration
        {
            get
            {
                return new Seat[]
                {
                    new Seat("Driver", 1),
                    new Seat("Passenger", 1),
                    new Seat("Rear bench", 2)
                };
            }
        }

        public static IEnumerable<Seat> TwoSeatConfiguration
        {
            get
            {
                return new Seat[]
                {
                    new Seat("Driver", 1),
                    new Seat("Passenger", 1)
                };
            }
        }

        public void Accept(ICarPartVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
