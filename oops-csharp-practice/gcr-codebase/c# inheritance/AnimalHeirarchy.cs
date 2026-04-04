using System;

abstract class Animal
{
    protected string Name;
    protected int Age;

    protected Animal(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public virtual void MakeSound()
    {
        Console.WriteLine("Animal makes a sound");
    }
}

class Dog : Animal
{
    public Dog(string name, int age) : base(name, age) { }
    public override void MakeSound()
    {
        Console.WriteLine("Dog barks");
    }
}

class Cat : Animal
{
    public Cat(string name, int age) : base(name, age) { }
    public override void MakeSound()
    {
        Console.WriteLine("Cat meows");
    }
}

class Bird : Animal
{
    public Bird(string name, int age) : base(name, age) { }
    public override void MakeSound()
    {
        Console.WriteLine("Bird chirps");
    }
}

class Program
{
    static void Main()
    {
        Animal a1 = new Dog("Tommy", 3);
        Animal a2 = new Cat("Kitty", 2);
        Animal a3 = new Bird("Parrot", 1);

        a1.MakeSound();
        a2.MakeSound();
        a3.MakeSound();
    }
}
