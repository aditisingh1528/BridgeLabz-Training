using System;

class Tab
{
     private BrowserHistory history;

    public Tab(string homePage)
    {
        this.history = new BrowserHistory(homePage);
    }

    public BrowserHistory History
    {
        get { return this.history; }
    }
}