using System;

interface IHistory
{
    void Visit(string url);
    void Back();
    void Forward();
    string CurrentPage { get; }
}