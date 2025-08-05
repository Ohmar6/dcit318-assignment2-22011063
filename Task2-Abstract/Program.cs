using System;

namespace AbstractClassDemo
{
    // Abstract base class
    abstract class Shape
    {
        public abstract double GetArea();
    }

    // Derived class: Circle
    class Circle : Shape
    {
        public double Radius { get; set; }

        public override double GetArea()
        {
            return Math.PI * Radius * Radius;
        }
    }

    // Derived class: Rectangle
    class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public override double GetArea()
        {
            return Width * Height;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create and display Circle area
            Circle circle = new Circle { Radius = 5 };
            Console.WriteLine($"Circle Area: {circle.GetArea():F2}");

            // Create and display Rectangle area
            Rectangle rectangle = new Rectangle { Width = 4, Height = 6 };
            Console.WriteLine($"Rectangle Area: {rectangle.GetArea():F2}");
        }
    }
}