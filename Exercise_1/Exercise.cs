namespace Exercise_1;

public class Exercise
{
    public static bool ContainsNegative(IEnumerable<int> numbers)
    {
        //your code goes here
        return numbers.Any(n => n < 0);

        //foreach (var number in numbers)
        //{
        //    if (number < 0)
        //    {
        //        return true; // Early return if a negative number is found
        //    }
        //}
        //return false; // Return false if no negative numbers are found
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
