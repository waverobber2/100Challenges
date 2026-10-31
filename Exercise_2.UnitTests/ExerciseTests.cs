using Xunit;

namespace Exercise_2.UnitTests;

public class ExerciseTests
{
    [Theory]
    [InlineData("Ada Lovelace", "Ada", "Lovelace")]
    [InlineData("Alan Turing", "Alan", "Turing")]
    [InlineData("Big DickedMoFo!", "Big", "DickedMoFo!")]
    public void Exercise_FullNameSubmitted_ReturnsFirstAndLastNamesSplit(string fullName, string expectedFirstName, string expectedLastName)
    {
        Assert.Equal((expectedFirstName, expectedLastName), Exercise.SplitFullName(fullName));
    }
}

/*
Split a full name into first and last names (⭐)
Exercise description:

Implement the SplitFullName method that takes a string representing a person's full 
name and returns a tuple with two values: first name and last name. Assume the full name 
contains exactly one space, separating the first and last name.

What you'll practice:
Returning multiple values from a method using a named tuple
Splitting strings

Example usage:

var result = Exercise.SplitFullName("Ada Lovelace");
// result.firstName == "Ada"
// result.lastName == "Lovelace"
*/
