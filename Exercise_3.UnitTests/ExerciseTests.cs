using Xunit;

namespace Exercise_3.UnitTests;

public class ExerciseTests
{
    [Fact]
    public void CountCharacterFrequencies_ReturnsExpectedCounts_ForBasicInput()
    {
        // Arrange
        const string input = "Hello!";

        // Act
        var result = Exercise.CountCharacterFrequencies(input);

        // Assert
        Assert.Equal(5, result.Count);
        Assert.Equal(1, result['H']);
        Assert.Equal(1, result['e']);
        Assert.Equal(2, result['l']);
        Assert.Equal(1, result['o']);
        Assert.Equal(1, result['!']);
    }

    [Fact]
    public void CountCharacterFrequencies_IsCaseSensitive()
    {
        // Arrange
        const string input = "aAaa";

        // Act
        var result = Exercise.CountCharacterFrequencies(input);

        // Assert
        Assert.Equal(2, result.Count);
        Assert.Equal(3, result['a']);
        Assert.Equal(1, result['A']);
    }

    [Fact]
    public void CountCharacterFrequencies_CountsSpacesAndSymbols()
    {
        // Arrange
        const string input = " a! a!";

        // Act
        var result = Exercise.CountCharacterFrequencies(input);

        // Assert
        Assert.Equal(3, result.Count);
        Assert.Equal(2, result[' ']);
        Assert.Equal(2, result['a']);
        Assert.Equal(2, result['!']);
    }

    [Fact]
    public void CountCharacterFrequencies_ReturnsEmptyDictionary_ForEmptyString()
    {
        // Arrange
        const string input = "";

        // Act
        var result = Exercise.CountCharacterFrequencies(input);

        // Assert
        Assert.Empty(result);
    }
}

/*
Count character frequencies in a string (⭐⭐)
Exercise description:

Implement the CountCharacterFrequencies method that takes a string and returns a dictionary 
mapping each character to the number of times it appears in the input.

The method should be case-sensitive, so 'H' and 'h' are treated as different characters. 
All characters, including spaces and symbols, should be counted.

What you'll practice:
Iterating over strings
Using a Dictionary to store and update values
Writing conditional logic to manage existing keys
Optionally using LINQ for grouping and counting (GroupBy and Count)

Example usage:
var result = CountCharacterFrequencies("Hello!");
// result: { ['H'] = 1, ['e'] = 1, ['l'] = 2, ['o'] = 1, ['!'] = 1 }
*/

