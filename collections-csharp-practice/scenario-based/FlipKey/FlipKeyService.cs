using System.Text;
using System.Text.RegularExpressions;

namespace FlipKey.Service
{
    // Contains business logic
    public class FlipKeyService
    {
        public string CleanseAndInvert(string input)
        {
            // Null or length validation
            if (string.IsNullOrEmpty(input) || input.Length < 6)
                return "";

            // Only alphabets allowed
            if (!Regex.IsMatch(input, "^[a-zA-Z]+$"))
                return "";

            input = input.ToLower();
            StringBuilder sb = new StringBuilder();

            // Remove even ASCII characters
            foreach (char c in input)
            {
                if ((int)c % 2 != 0)
                    sb.Append(c);
            }

            // Reverse string
            char[] arr = sb.ToString().ToCharArray();
            System.Array.Reverse(arr);

            // Uppercase even index characters
            for (int i = 0; i < arr.Length; i++)
            {
                if (i % 2 == 0)
                    arr[i] = char.ToUpper(arr[i]);
            }

            return new string(arr);
        }
    }
}