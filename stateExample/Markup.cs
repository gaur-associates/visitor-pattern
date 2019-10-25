using System;

namespace stateExample
{
    public class Markup : IVisitor
    {
        public void Visit(Vehicle vehicle)
        {
            vehicle.Cost += 7500;
        }
    }
}
