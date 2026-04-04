using System;
using System.Text.RegularExpressions;

public class PasswordValidator
{
    //method to validate password strength
    public bool IsValid(string password)
    {
        if (password == null || password.Length < 8)
        {
            return false;
        }

        bool hasUppercase = Regex.IsMatch(password, "[A-Z]");
        bool hasDigit = Regex.IsMatch(password, "[0-9]");

        return hasUppercase && hasDigit;
    }
}
