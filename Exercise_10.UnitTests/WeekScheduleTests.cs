using Xunit;

namespace Exercise_10.UnitTests;

public class WeekScheduleTests
{
    [Fact]
    public void WeekSchedule()
    {
        Assert.True(true);
    }

}

/*
Implement a weekly schedule with multiple custom indexers (⭐⭐)
Exercise description:

Implement the WeekSchedule class that allows storing and retrieving plans 
for days of the week using two custom indexers.

The first indexer accepts a DayOfWeek enum value.

The second indexer accepts a string and attempts to parse it into a DayOfWeek. 
If parsing fails, it should throw an ArgumentException.

Both should use the underlying _plans Dictionary.

The string-based indexer should work regardless of casing (e.g. "monday" or 
"MONDAY" are both valid).

If no note is stored for a given day, the indexer should return null.

What you'll practice:
Creating a custom indexer with an enum as the index type
Overloading an indexer to also accept a string
Parsing strings into enums with Enum.TryParse
Throwing exceptions for invalid input
Working with Dictionaries

Example usage:

var schedule = new WeekSchedule();
schedule[DayOfWeek.Monday] = "Gym";
schedule["Friday"] = "Dinner with friends";
 
var mondayNote = schedule["monday"];   // => "Gym" (case-insensitive)
var fridayNote = schedule[DayOfWeek.Friday]; // => "Dinner with friends"
var tuesdayNote = schedule["Tuesday"]; // => null
 
// schedule["Funday"]; // => throws ArgumentException
*/
