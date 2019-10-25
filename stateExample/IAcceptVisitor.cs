using System;

namespace stateExample
{
    public interface IAcceptVisitor
    {
        void Accept(IVisitor visitor);
    }
}
