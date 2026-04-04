using System;

public class UserRegistration
{
    //method to register user
    public bool RegisterUser(string username, string email, string password)
    {
        if (string.IsNullOrEmpty(username))
        {
            throw new ArgumentException("Invalid username");
        }

        if (string.IsNullOrEmpty(email) || !email.Contains("@"))
        {
            throw new ArgumentException("Invalid email");
        }

        if (string.IsNullOrEmpty(password) || password.Length < 6)
        {
            throw new ArgumentException("Invalid password");
        }

        return true;
    }
}
