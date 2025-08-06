# dcit318-assignment2-22011063

## Final `README.md` — DCIT 318 Assignment 2


# DCIT 318 - Object-Oriented Programming in C#
## Assignment 2: Inheritance, Abstract Classes, and Interfaces


## Author

**Gideon Mangortey**  
University of Ghana, Legon  
Course: DCIT 318 - Object-Oriented Programming  
Semester: Year 3, Semester 2


## Project Overview

This repository contains three C# console applications demonstrating key Object-Oriented Programming (OOP) concepts:

- Inheritance and Method Overriding  
- Abstract Classes and Polymorphism  
- Interfaces and Implementation

Each task is implemented in a separate namespace and folder for clarity.


## Concepts Demonstrated

### Inheritance and Overriding
- Base class `Animal` with virtual method `MakeSound()`
- Derived classes `Dog` and `Cat` override the method

### Abstract Classes
- Abstract class `Shape` with method `GetArea()`
- Derived classes `Circle` and `Rectangle` implement area calculation

### Interfaces
- Interface `IMovable` with method `Move()`
- Classes `Car` and `Bicycle` implement the interface


## Project Structure

dcit318-assignment2-22011063/
│
├── Task1-Inheritance/
│   └── Program.cs
│
├── Task2-Abstract/
│   └── Program.cs
│
├── Task3-Interface/
│   └── Program.cs
│
└── README.md


## How to Run

1. Clone the repository:
   git clone https://github.com/Ohmar6/dcit318-assignment2-22011063.git

2. Open each folder in Visual Studio or VS Code.
3. Build and run the application using the terminal or IDE.


## Sample Output

Inheritance Demo:

Animal:
Some generic sound

Dog:
Bark

Cat:
Meow

Abstract Class Demo:

Circle Area: 78.54
Rectangle Area: 24.00

Interface Demo:

Car is moving
Bicycle is moving


## Learning Outcomes

- Practiced OOP principles in C#
- Implemented inheritance, abstraction, and interfaces
- Improved code organization and GitHub workflow


## License

This project is for academic purposes under the University of Ghana curriculum.  
Feel free to fork and adapt with attribution.