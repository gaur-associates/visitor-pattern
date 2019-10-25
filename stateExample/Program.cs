using System;

namespace stateExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var car = new Car();
            var camry = new Camry();
            var truck = new Truck();

            var promotion = new Promotion();
            car.Accept(promotion);
            camry.Accept(promotion);

            var markup = new Markup();
            truck.Accept(markup);

            Console.WriteLine($"car - {car.Cost}");
            Console.WriteLine($"camry - {camry.Cost}");
            Console.WriteLine($"truck - {truck.Cost}");
        }
    }
}
