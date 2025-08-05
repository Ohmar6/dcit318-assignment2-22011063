using System;

namespace InterfaceDemo
{
    // Define the interface
    interface IMovable
    {
        void Move();
    }

    // Class that implements IMovable
    class Car : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Car is moving");
        }
    }

    // Another class that implements IMovable
    class Bicycle : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Bicycle is moving");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create instances of Car and Bicycle
            IMovable myCar = new Car();
            IMovable myBike = new Bicycle();

            // Call Move() on each
            myCar.Move();
            myBike.Move();
        }
    }
}