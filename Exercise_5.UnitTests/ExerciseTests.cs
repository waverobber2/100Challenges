using Xunit;

namespace Exercise_5.UnitTests;

public class ExerciseTests
{
    [Fact]
    public void CalculateTotalBreakTime_ReturnsSumOfAllBreaks()
    {
        // Arrange
        var breaks = new List<(DateTime Start, DateTime End)>
        {
            (new DateTime(2023, 4, 1, 9, 0, 0),
            new DateTime(2023, 4, 1, 9, 15, 0)),
            (new DateTime(2023, 4, 1, 12, 30, 0),
            new DateTime(2023, 4, 1, 13, 0, 0)),
            (new DateTime(2023, 4, 1, 15, 45, 0),
            new DateTime(2023, 4, 1, 16, 0, 0))
        };

        // Act
        var result = Exercise.CalculateTotalBreakTime(breaks);

        // Assert
        Assert.Equal(TimeSpan.FromMinutes(60), result);
    }

    [Fact]
    public void CalculateTotalBreakTime_ReturnsZero_ForEmptyList()
    {
        // Arrange
        var breaks = new List<(DateTime Start, DateTime End)>();

        // Act
        var result = Exercise.CalculateTotalBreakTime(breaks);

        // Assert
        Assert.Equal(TimeSpan.Zero, result);
    }

    [Fact]
    public void CalculateTotalBreakTime_ThrowsArgumentException_WhenStartIsNotBeforeEnd()
    {
        // Arrange
        var breaks = new List<(DateTime Start, DateTime End)>
        {
            (new DateTime(2023, 4, 1, 10, 0, 0),
            new DateTime(2023, 4, 1, 10, 0, 0))
        };

        // Act & Assert
        var ex = Assert.Throws<ArgumentException>(() => Exercise.CalculateTotalBreakTime(breaks));
        Assert.Equal("Start time must be before end time.", ex.Message);
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
