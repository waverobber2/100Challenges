using Xunit;

namespace Exercise_9.UnitTests;

public class ExerciseTests
{
    [Theory]
    [InlineData("radar", true)]
    [InlineData("madam", true)]
    [InlineData("hello", false)]
    [InlineData("Racecar", false)]   // case-sensitive
    [InlineData("race car", false)]  // spaces included
    [InlineData("a", true)]
    [InlineData("", true)]
    public void IsPalindrome_WhenInputIsProvided_ReturnsExpectedResult(string input, bool expected)
    {
        // Act
        var result = Exercise.IsPalindrome(input);

        // Assert
        Assert.Equal(expected, result);
    }
}
