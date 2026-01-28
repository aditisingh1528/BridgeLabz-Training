using System;

public class DatabaseConnection
{
    public bool IsConnected { get; private set; }

    //method to connect to database
    public void Connect()
    {
        IsConnected = true;
    }

    //method to disconnect from database
    public void Disconnect()
    {
        IsConnected = false;
    }
}
