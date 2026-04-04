using System;

// Interfaces
interface IFlyable
{
    void Fly();
}

interface ISwimmable
{
    void Swim();
}

//Base Class
class Bird
{
    public string Name;

    public Bird(string name)
    {
        Name = name;
    }

    public void Display()
    {
        Console.WriteLine("Bird Name: " + Name);
    }
}

//Derived Classes
class Eagle : Bird, IFlyable
{
    public Eagle() : base("Eagle") { }

    public void Fly()
    {
        Console.WriteLine("Eagle is flying high in the sky.");
    }
}

class Sparrow : Bird, IFlyable
{
    public Sparrow() : base("Sparrow") { }

    public void Fly()
    {
        Console.WriteLine("Sparrow is flying from tree to tree.");
    }
}

class Duck : Bird, ISwimmable
{
    public Duck() : base("Duck") { }

    public void Swim()
    {
        Console.WriteLine("Duck is swimming in the pond.");
    }
}

class Penguin : Bird, ISwimmable
{
    public Penguin() : base("Penguin") { }

    public void Swim()
    {
        Console.WriteLine("Penguin is swimming in cold water.");
    }
}

class Seagull : Bird, IFlyable, ISwimmable
{
    public Seagull() : base("Seagull") { }

    public void Fly()
    {
        Console.WriteLine("Seagull is flying near the sea.");
    }

    public void Swim()
    {
        Console.WriteLine("Seagull is swimming on water.");
    }
}

class BirdSanctuary
{
    static void Main()
    {
        Console.Write("Enter number of birds to add: ");
        int count = Convert.ToInt32(Console.ReadLine());

        Bird[] birds = new Bird[count];

        for (int i = 0; i < count; i++)
        {
            Console.WriteLine("\nChoose Bird Type:");
            Console.WriteLine("1. Eagle");
            Console.WriteLine("2. Sparrow");
            Console.WriteLine("3. Duck");
            Console.WriteLine("4. Penguin");
            Console.WriteLine("5. Seagull");
            Console.Write("Enter choice: ");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1: birds[i] = new Eagle(); break;
                case 2: birds[i] = new Sparrow(); break;
                case 3: birds[i] = new Duck(); break;
                case 4: birds[i] = new Penguin(); break;
                case 5: birds[i] = new Seagull(); break;
                default:
                    Console.WriteLine("Invalid choice, adding Sparrow by default.");
                    birds[i] = new Sparrow();
                    break;
            }
        }

        Console.WriteLine("\n---- Bird Activities in Sanctuary ----");

        foreach (Bird bird in birds)
        {
            bird.Display();

            if (bird is IFlyable)
            {
                ((IFlyable)bird).Fly();
            }

            if (bird is ISwimmable)
            {
                ((ISwimmable)bird).Swim();
            }

            Console.WriteLine();
        }
    }
}