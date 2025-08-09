using System;

namespace InterfacesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Interfaces Demo (IMovable)");

            IMovable car = new Car();
            car.Move();          // Car is moving

            IMovable bicycle = new Bicycle();
            bicycle.Move();      // Bicycle is moving
        }
    }
}
