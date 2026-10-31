namespace Exercise_2;

public class Exercise
{
    public static (string firstName, string lastName) SplitFullName(string fullName)
    {
        //your code goes here
        var names = fullName.Split(' ');
        return (firstName: names[0], lastName: names[1]); //to be clear on what is being returned, we can use named tuple elements
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
