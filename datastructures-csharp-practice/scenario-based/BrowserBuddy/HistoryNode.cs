using System;

public class HistoryNode
{
    public string Url
    {
        get; private set;
    }

    public HistoryNode Prev
    {
        get; set;
    }
    public HistoryNode Next
    {
        get; set;
    }

    public HistoryNode(string url)
    {
        this.Url = url;
        this.Prev = null;
        this.Next = null;
    }
}