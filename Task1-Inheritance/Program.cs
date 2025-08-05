using System;

namespace InheritanceAndOverriding
{
    // Base class
    class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Some generic sound");
        }
    }

    // Derived class: Dog
    class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Bark");
        }
    }

    // Derived class: Cat
    class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Meow");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create instances of each class
            Animal genericAnimal = new Animal();
            Dog dog = new Dog();
            Cat cat = new Cat();

            // Call MakeSound() on each instance
            Console.WriteLine("Animal:");
            genericAnimal.MakeSound();

            Console.WriteLine("\nDog:");
            dog.MakeSound();

            Console.WriteLine("\nCat:");
            cat.MakeSound();
        }
    }
}