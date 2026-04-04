using System;

interface IReservable
{
    void ReserveItem();
    bool CheckAvailability();
}

abstract class LibraryItem
{
    private int itemId;
    private string title;
    private string author;

    protected LibraryItem(int id, string title, string author)
    {
        itemId = id;
        this.title = title;
        this.author = author;
    }

    public abstract int GetLoanDuration();

    public void GetItemDetails()
    {
        Console.WriteLine($"{title} by {author}");
    }
}

class Book : LibraryItem, IReservable
{
    public Book(int id, string title, string author)
        : base(id, title, author) { }

    public override int GetLoanDuration() => 14;
    public void ReserveItem() { }
    public bool CheckAvailability() => true;
}
