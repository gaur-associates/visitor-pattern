using System;

namespace stateExample
{
    public class Promotion : IVisitor
    {
        public void Visit(Vehicle vehicle)
        {
            vehicle.Cost = (int)(vehicle.Cost * .9);
        }
    }
}
