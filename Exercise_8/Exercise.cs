using System.Globalization;

namespace Exercise_8;

public class Exercise
{
    public static bool TryExtractDateComponents(string dateInput, out int year, out int month, out int day)
    {
        if (!DateTime.TryParse(dateInput, provider: CultureInfo.InvariantCulture, result: out DateTime parsedDate))
        {
            year = month = day = 0;
            return false;
        }

        year = parsedDate.Year;
        month = parsedDate.Month;
        day = parsedDate.Day;
        return true;
    }
}

/*
Try parsing a date and extracting its components (⭐)
Exercise description:

Implement the TryExtractDateComponents method that takes a string representing a 
date and attempts to extract its components: year, month, and day.

If the input can be successfully parsed into a DateTime, the method should:
Set the out parameters for year, month, and day
Return true

If the input cannot be parsed, the method should:
Set all out values to zero
Return false

To ensure your code works consistently regardless of the system’s culture, use a 
parsing approach that is culture-invariant. Consider using DateTime.TryParse.

What you'll practice:
Defining and using out parameters in your own method
Calling built-in methods like DateTime.TryParse with out
Writing code that works consistently across cultures and locales
Optionally, structuring method calls with named parameters for clarity and readability

Example usage:

bool result = Exercise.TryExtractDateComponents(
    dateInput: "2024-12-15",
    year: out var y,
    month: out var m,
    day: out var d
);
// result == true, y == 2024, m == 12, d == 15
 
result = Exercise.TryExtractDateComponents(
    dateInput: "not-a-date",
    year: out y,
    month: out m,
    day: out d
);
// result == false, y/m/d == 0 * 
*/