using System;

class BrowserHistory : IHistory
{
    private HistoryNode current;

    public BrowserHistory(string homePage)
    {
        this.current = null;
        this.Visit(homePage);
    }

    public void Visit(string url)
    {
        HistoryNode newNode = new HistoryNode(url);

        if (this.current != null)
        {
            this.current.Next = newNode;
            newNode.Prev = this.current;
        }

        this.current = newNode;
        System.Console.WriteLine("Visited: " + url);
    }

    public void Back()
    {
        if (this.current != null && this.current.Prev != null)
        {
            this.current = this.current.Prev;
            System.Console.WriteLine("Back to: " + this.current.Url);
        }
        else
        {
            System.Console.WriteLine("No previous page");
        }
    }

    public void Forward()
    {
        if (this.current != null && this.current.Next != null)
        {
            this.current = this.current.Next;
            System.Console.WriteLine("Forward to: " + this.current.Url);
        }
        else
        {
            System.Console.WriteLine("No forward page");
        }
    }

    public string CurrentPage
    {
        get
        {
            return this.current != null ? this.current.Url : "No page";
        }
    }
}