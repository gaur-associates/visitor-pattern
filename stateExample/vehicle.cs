using System;

namespace stateExample
{
    public class Vehicle : IAcceptVisitor
    {
        virtual public int Cost { get; set; } = 0;

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
    public class Car : Vehicle
    {
        override public int Cost { get; set; } = 5000;

    }
    public class Camry : Vehicle
    {
        override public int Cost { get; set; } = 10000;
    }
    public class Truck : Vehicle
    {
        override public int Cost { get; set; } = 150000;
    }
}
