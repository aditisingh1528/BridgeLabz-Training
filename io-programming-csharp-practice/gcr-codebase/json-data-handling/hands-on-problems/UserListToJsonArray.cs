using System;
using System.Collections.Generic;
using Newtonsoft.Json;

class UserProfile
{
    public string UserName { get; set; }
    public int UserAge { get; set; }
}

class UserListToJsonArray
{
    static void Main(string[] args)
    {
        List<UserProfile> userProfiles = new List<UserProfile>();

        Console.WriteLine("Enter number of users:");
        int userCount = int.Parse(Console.ReadLine());

        //Collecting user input
        for (int i = 0; i < userCount; i++)
        {
            UserProfile userProfile = new UserProfile();

            Console.WriteLine("Enter user name:");
            userProfile.UserName = Console.ReadLine();

            Console.WriteLine("Enter user age:");
            userProfile.UserAge = int.Parse(Console.ReadLine());

            userProfiles.Add(userProfile);
        }

        //Converting list to JSON array
        string usersJsonArray = JsonConvert.SerializeObject(userProfiles, Formatting.Indented);

        Console.WriteLine("JSON Array:");
        Console.WriteLine(usersJsonArray);
    }
}
