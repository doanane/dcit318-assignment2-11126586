// Abstract classes and methods example (Shape, Circle, Rectangle)
﻿using System;


namespace AbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Abstract Classes and Methods Demo");

            var circle = new Circle(3.0); // radius 3
            Console.WriteLine($"Circle with radius {circle.Radius}, area = {circle.GetArea():F2}");

            var rectangle = new Rectangle(4.0, 5.0);
            Console.WriteLine($"Rectangle {rectangle.Width} x {rectangle.Height}, area = {rectangle.GetArea():F2}");
        }
    }
}
