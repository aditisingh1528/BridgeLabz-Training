using System;

public class PasswordCracker
{
    private string actualPassword;
    private bool isCracked = false;

    public PasswordCracker(string password)
    {
        actualPassword = password;
    }

    //Backtracking method
    public void CrackPassword(char[] set, char[] current, int index)
    {
        //Stop if already found
        if (isCracked)
        {
            return;
        }

        
        //Base condition:password length reached
        if (index == current.Length)
        {
            string attempt = new string(current);

            Console.WriteLine("Trying: "+ attempt);

            if (attempt == actualPassword)
            {
                Console.WriteLine("Password Cracked: " + attempt);
                isCracked = true;
            }
            return;
        }

        //Try all characters for current position
        for (int i = 0; i < set.Length; i++)
        {
            current[index] = set[i];
            CrackPassword(set, current, index + 1);
        }
    }
}