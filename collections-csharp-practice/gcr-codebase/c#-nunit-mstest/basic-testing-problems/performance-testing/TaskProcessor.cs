using System;
using System.Threading;

public class TaskProcessor
{
    //method that simulates long running task
    public string LongRunningTask()
    {
        Thread.Sleep(3000);
        return "Completed";
    }
}
