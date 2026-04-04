using System;

class CallLog
{
    public string PhoneNumber;
    public string Message;
    public DateTime TimeStamp;

    public void Display()
    {
        Console.WriteLine("Phone Number : " + PhoneNumber);
        Console.WriteLine("Message      : " + Message);
        Console.WriteLine("Time         : " + TimeStamp);
        Console.WriteLine();
    }
}

class CallLogManager
{
    static CallLog[] logs = new CallLog[10];
    static int count = 0;

    static void Main()
    {
        int choice;

        do
        {
            Console.WriteLine("\nCustomer Service Call Log Manager");
            Console.WriteLine("1. Add Call Log");
            Console.WriteLine("2. Search by Keyword");
            Console.WriteLine("3. Filter by Time Range");
            Console.WriteLine("4. Exit");
            Console.Write("Enter choice: ");

            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AddCallLog();
                    break;

                case 2:
                    SearchByKeyword();
                    break;

                case 3:
                    FilterByTime();
                    break;

                case 4:
                    Console.WriteLine("Exiting program...");
                    break;

                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }

        } while (choice != 4);
    }

    //Add Call Log
    static void AddCallLog()
    {
        if (count >= logs.Length)
        {
            Console.WriteLine("Call log storage is full");
            return;
        }

        CallLog log = new CallLog();

        Console.Write("Enter phone number: ");
        log.PhoneNumber = Console.ReadLine();

        Console.Write("Enter message: ");
        log.Message = Console.ReadLine();

        log.TimeStamp = DateTime.Now;

        logs[count] = log;
        count++;

        Console.WriteLine("Call log added successfully");
    }

    //Search by Keyword
    static void SearchByKeyword()
    {
        Console.Write("Enter keyword to search: ");
        string keyword = Console.ReadLine();

        bool found = false;

        for (int i = 0; i < count; i++)
        {
            if (logs[i].Message.Contains(keyword))
            {
                logs[i].Display();
                found = true;
            }
        }

        if (!found)
        {
            Console.WriteLine("No logs found with this keyword");
        }
    }

    //Filter by Time
    static void FilterByTime()
    {
        Console.Write("Enter start date (yyyy-mm-dd): ");
        DateTime start = Convert.ToDateTime(Console.ReadLine());

        Console.Write("Enter end date (yyyy-mm-dd): ");
        DateTime end = Convert.ToDateTime(Console.ReadLine());

        bool found = false;

        for (int i = 0; i < count; i++)
        {
            if (logs[i].TimeStamp >= start && logs[i].TimeStamp <= end)
            {
                logs[i].Display();
                found = true;
            }
        }

        if (!found)
        {
            Console.WriteLine("No logs found in this time range");
        }
    }
}