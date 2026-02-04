using System;
using System.Collections.Generic;

Console.WriteLine("hello oop");

var p = new Person("Himaya", "Perera", new DateOnly(2001, 07, 21));
var p2 = new Person("Supun", "Perera", new DateOnly(2002, 07, 21));

// Adding Pets
p.Pets.Add(new Dog("Fried"));
p.Pets.Add(new Dog("Perry"));
p2.Pets.Add(new Cat("Meow"));

List<Person> people = [p, p2];

foreach (var person in people) // Fixed typo: pepole -> people
{
    Console.WriteLine($"{person}");

    foreach (var pet in person.Pets)
    {
        // This will print the Pet's name and its sound
        Console.WriteLine($"             {pet}");
    }
}

// --- CLASS DEFINITIONS ---

public class Person
{
    public Person(string first, string last, DateOnly bd)
    {
        FirstName = first;
        LastName = last;
        Birthday = bd;
    }

    public string FirstName { get; }
    public string LastName { get; }
    public DateOnly Birthday { get; }

    // List of Pets (using the base class Pet)
    public List<Pet> Pets { get; } = new();

    public override string ToString() => $"{FirstName} {LastName}";
}

// Base class for Inheritance
public abstract class Pet(string name)
{
    public string Name { get; } = name;
    public abstract string MakeSound();
    public override string ToString() => $"{Name} ({MakeSound()})";
}

// Derived classes
public class Dog(string name) : Pet(name)
{
    public override string MakeSound() => "Woof!";
}

public class Cat(string name) : Pet(name)
{
    public override string MakeSound() => "Meow!";
}