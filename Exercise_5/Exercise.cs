namespace Exercise_5;

public class Exercise
{
    public static TimeSpan CalculateTotalBreakTime(List<(DateTime Start, DateTime End)> breaks)
    {
        //your code goes here
        foreach (var (start, end) in breaks)
        {
            if (start >= end)
            {
                throw new ArgumentException("Start time must be before end time.");
            }
        }

        return new TimeSpan(breaks.Sum(b => (b.End - b.Start).Ticks));
    }
}

/*
Calculate total break time from multiple time ranges (⭐)
Exercise description:

A company tracks employee breaks using start and end timestamps. Each break is 
represented as a pair of DateTime values—when the break started and when it ended.

Implement the CalculateTotalBreakTime method that receives a list of tuples, each 
containing a start and end DateTime, and returns the total break time as a TimeSpan.

Assume that each start is before its corresponding end.

What you'll practice:
Working with DateTime and TimeSpan values
Using tuples and tuple deconstruction

Example usage:

var breaks = new List<(DateTime, DateTime)>
{
(new DateTime(2023, 4, 1, 9, 0, 0), new DateTime(2023, 4, 1, 9, 15, 0)),
(new DateTime(2023, 4, 1, 12, 30, 0), new DateTime(2023, 4, 1, 13, 0, 0)),
(new DateTime(2023, 4, 1, 15, 45, 0), new DateTime(2023, 4, 1, 16, 0, 0))
};

var result = CalculateTotalBreakTime(breaks); // => 00:60:00 (60 minutes total)
*/

