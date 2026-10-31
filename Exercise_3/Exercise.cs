namespace Exercise_3;

public class Exercise
{
    public static Dictionary<char, int> CountCharacterFrequencies(string input)
    {
        var dictionary = new Dictionary<char, int>();
        foreach (char c in input)
        {
            if (dictionary.ContainsKey(c))
            {
                dictionary[c]++;
            }
            else
            {
                dictionary[c] = 1;
            }
        }
        return dictionary;
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

 
////////////////////////////   SAMPLE DICTIONARY USAGE  //////////////////////////

using System;
using System.Collections.Generic;

namespace DictionaryDemo
{
    class Program
    {
        static void Main()
        {
            // Initialize a dictionary
            Dictionary<int, string> employees = new Dictionary<int, string>()
            {
                { 1001, "Alice" },
                { 1002, "Bob" },
                { 1003, "Charlie" }
            };

            Console.WriteLine("Initial Dictionary:");
            DisplayDictionary(employees);

            // Add a new item
            employees.Add(1004, "David");

            Console.WriteLine("\nAfter Adding David:");
            DisplayDictionary(employees);

            // Access a value by key
            Console.WriteLine($"\nEmployee 1002: {employees[1002]}");

            // Check if a key exists
            int keyToFind = 1003;

            if (employees.ContainsKey(keyToFind))
            {
                Console.WriteLine($"Key {keyToFind} exists.");
            }

            // Update a value
            employees[1003] = "Charles";

            Console.WriteLine("\nAfter Updating Charlie to Charles:");
            DisplayDictionary(employees);

            // Remove an entry
            employees.Remove(1001);

            Console.WriteLine("\nAfter Removing Alice:");
            DisplayDictionary(employees);

            // TryGetValue (safer than direct indexing)
            if (employees.TryGetValue(1004, out string employeeName))
            {
                Console.WriteLine($"\nFound employee: {employeeName}");
            }
            else
            {
                Console.WriteLine("\nEmployee not found.");
            }
        }

        static void DisplayDictionary(Dictionary<int, string> dictionary)
        {
            foreach (KeyValuePair<int, string> item in dictionary)
            {
                Console.WriteLine($"ID: {item.Key}, Name: {item.Value}");
            }
        }
    }
}
*/
