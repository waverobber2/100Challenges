namespace Exercise_9;

public class Exercise
{
    public static bool IsPalindrome(string input)
    {
        var left = 0;
        var right = input.Length - 1;

        while (left < right)
        {
            if (input[left] != input[right])
            {
                return false;
            }

            left++;
            right--;
        }
        return true;
    }

    //public static bool IsPalindrome_2(string input)
    //{
    //    for (int i = 0; i < input.Length / 2; i++)
    //    {
    //        if (input[i] != input[input.Length - 1 - i])
    //        {
    //            return false;
    //        }
    //    }
    //    return true;
    //}
}

/*
Check if a string is a palindrome (⭐)
Exercise description:

Implement the IsPalindrome method that checks whether a given string is a 
palindrome. A palindrome reads the same forward and backward. For example, 
the words "madam" or "radar" are palindromes, but "hello" is not.

The comparison should be case-sensitive and should include all characters 
(spaces, punctuation, etc.).

Return true if the string is a palindrome; otherwise, return false.

What you'll practice:
Iterating through strings from both ends
Using the index from end operator ^
Optionally, using LINQ or string reversal for comparison

Example usage:

var result = IsPalindrome("radar");        // => true
var result = IsPalindrome("hello");        // => false
var result = IsPalindrome("Racecar");      // => false (case-sensitive)
var result = IsPalindrome("madam");        // => true
var result = IsPalindrome("race car");     // => false (space)
*/
