using System;

// Encapsulated user profile
public class UserProfile
{
    private string userName;
    private int age;

    public string UserName
    {
        get { return userName; }
        set { userName = value; }
    }

    public int Age
    {
        get { return age; }
        set
        {
            if (value > 0)
                age = value;
        }
    }

    public UserProfile(string name, int age)
    {
        UserName = name;
        Age = age;
    }
}