using System;

public class StringUtils
{
    //method to reverse a string
    public string Reverse(string str)
    {
        if (str == null)
        {
            return null;
        }

        char[] chars = str.ToCharArray();
        Array.Reverse(chars);
        return new string(chars);
    }

    //method to check palindrome
    public bool IsPalindrome(string str)
    {
        if (str == null)
        {
            return false;
        }

        string reversed = Reverse(str);
        return str.Equals(reversed, StringComparison.OrdinalIgnoreCase);
    }

    //method to convert string to uppercase
    public string ToUpperCase(string str)
    {
        if (str == null)
        {
            return null;
        }

        return str.ToUpper();
    }
}
