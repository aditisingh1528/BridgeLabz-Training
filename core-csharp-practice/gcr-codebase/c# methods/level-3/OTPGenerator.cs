using System;

public class OTPGenerator
{
    static void Main()
    {
        int[] otps = new int[10];

        // Generate OTPs
        for (int i = 0; i < 10; i++)
        {
            otps[i] = GenerateOTP();
            Console.WriteLine("OTP " + (i + 1) + ": " + otps[i]);
        }

        // Check uniqueness
        bool isUnique = AreOTPsUnique(otps);
        Console.WriteLine("\nAll OTPs are unique: " + isUnique);
    }

    // a. Generate 6-digit OTP using Math.Random()
    public static int GenerateOTP()
    {
        Random random = new Random();
        return random.Next(100000, 1000000);
    }

    // c. Check if all OTPs are unique
    public static bool AreOTPsUnique(int[] otps)
    {
        for (int i = 0; i < otps.Length; i++)
        {
            for (int j = i + 1; j < otps.Length; j++)
            {
                if (otps[i] == otps[j])
                    return false;
            }
        }
        return true;
    }
}
