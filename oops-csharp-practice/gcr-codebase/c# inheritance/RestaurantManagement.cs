using System;

interface IWorker
{
    void Work();
}

class Person
{
    protected string Name;
    public Person(string n) { Name = n; }
}

class Chef : Person, IWorker
{
    public Chef(string n) : base(n) { }
    public void Work() => Console.WriteLine("Chef cooks");
}

class Program
{
    static void Main()
    {
        Chef c = new Chef("Ramesh");
        c.Work();
    }
}
