using System;
using System.Globalization;

public class DateFormatter
{
    //method to format date from yyyy-MM-dd to dd-MM-yyyy
    public string FormatDate(string inputDate)
    {
        DateTime parsedDate;

        bool isValid = DateTime.TryParseExact(
            inputDate,
            "yyyy-MM-dd",
            CultureInfo.InvariantCulture,
            DateTimeStyles.None,
            out parsedDate
        );

        if (!isValid)
        {
            throw new FormatException("Invalid date format");
        }

        return parsedDate.ToString("dd-MM-yyyy");
    }
}
