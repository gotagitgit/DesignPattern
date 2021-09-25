using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Visitor.WithVisitor
{
    public interface ICarPartVisitor
    {
        void Visit(Engine engine);
        void Visit(Seat seat);
    }
}
