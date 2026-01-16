using System;

class BrowserMenu
{
    private Tab currentTab;
    private ClosedTabStack closedTabs;

    public BrowserMenu()
    {
        this.currentTab = new Tab("home.com");
        this.closedTabs = new ClosedTabStack(5);
    }

    public void Start()
    {
        while (true)
        {
            Console.WriteLine("\n--- BrowserBuddy Menu ---");
            Console.WriteLine("1. Visit New Page");
            Console.WriteLine("2. Back");
            Console.WriteLine("3. Forward");
            Console.WriteLine("4. Close Tab");
            Console.WriteLine("5. Restore Closed Tab");
            Console.WriteLine("6. Show Current Page");
            Console.WriteLine("7. Exit");
            Console.Write("Enter choice: ");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter URL: ");
                    string url = Console.ReadLine();
                    this.currentTab.History.Visit(url);
                    break;

                case 2:
                    this.currentTab.History.Back();
                    break;

                case 3:
                    this.currentTab.History.Forward();
                    break;

                case 4:
                    this.closedTabs.Push(this.currentTab);
                    this.currentTab = null;
                    Console.WriteLine("Tab closed");
                    break;

                case 5:
                    this.currentTab = this.closedTabs.Pop();
                    break;

                case 6:
                    if (this.currentTab != null)
                        Console.WriteLine("Current Page: " + this.currentTab.History.CurrentPage);
                    else
                        Console.WriteLine("No active tab");
                    break;

                case 7:
                    Console.WriteLine("Exiting BrowserBuddy...");
                    return;

                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
    }
}