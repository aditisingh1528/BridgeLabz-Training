using System;

class Person
{
    private string name;
    private int age;

    // Parameterized constructor
    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    // Copy constructor
    public Person(Person other)
    {
        this.name = other.name;
        this.age = other.age;
    }

    public void Display()
    {
        Console.WriteLine($"{name}, {age}");
    }

    static void Main()
    {
        Person p1 = new Person("Aditi", 21);
        Person p2 = new Person(p1);

        p2.Display();
    }
}