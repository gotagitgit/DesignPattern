using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Visitor.WithVisitor
{
    public interface ICarVisitor : ICarPartVisitor
    {
        void VisitCar(string make, string model);
    }
}
