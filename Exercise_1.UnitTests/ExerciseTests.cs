using Xunit;

namespace Exercise_1.UnitTests;

public class ExerciseTests
{
    [Theory]
    [InlineData(new int[] { 5, 3, 0, -1, 7 }, true)]
    [InlineData(new int[] { 1, 2, 3, 4 }, false)]
    [InlineData(new int[] { -5, -3, -1 }, true)]
    public void Exercise_ChecksArrayForNegativeNumbers_ReturnsExpectedResult(int[] numbers, bool expected)
    {
        var result = Exercise.ContainsNegative(numbers);
        Assert.Equal(expected, result);
    }

    public static IEnumerable<object[]> ListTestData =>
        new List<object[]>
        {
        new object[] { new List<int> { 5, 3, 0, -1, 7 }, true },
        new object[] { new List<int> { 1, 2, 3, 4 }, false },
        new object[] { new List<int> { -5, -3, -1 }, true },
        };

    [Theory]
    [MemberData(nameof(ListTestData))]
    public void Exercise_ChecksListForNegativeNumbers_ReturnsExpectedResult(List<int> numbers, bool expected)
    {
        var result = Exercise.ContainsNegative(numbers);
        Assert.Equal(expected, result);
    }
}

/*
Check if a collection contains any negative numbers (⭐)
Exercise description:

Implement the ContainsNegative method that checks whether a sequence of integers contains 
at least one negative number. Keep performance in mind.

What you'll practice:
Using foreach loops and IEnumerable
Applying early return to improve efficiency
Working with basic conditional logic
Using the Any method from LINQ

Example usage:
var result = ContainsNegative(new List<int> { 5, 3, 0, -1, 7 }); // => true
var result = ContainsNegative(new List<int> { 1, 2, 3, 4 });     // => false
*/

