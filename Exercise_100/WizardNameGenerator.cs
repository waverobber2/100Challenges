namespace Exercise_100
{
    public static class WizardNameGenerator
    {
        public static string GenerateWizardName(List<string> names, List<string> titles, Random random)
        {
            ValidateInput(names, titles, random);

            //your code goes here
            return string.Empty;
        }

        private static void ValidateInput(List<string> names, List<string> titles, Random random)
        {
            if (names is null)
            {
                throw new ArgumentNullException(nameof(names));
            }
            if (titles is null)
            {
                throw new ArgumentNullException(nameof(titles));
            }
            if (random is null)
            {
                throw new ArgumentNullException(nameof(random));
            }
            if (names.Count == 0)
            {
                throw new ArgumentException("Names list cannot be empty.", nameof(names));
            }
            if (titles.Count == 0)
            {
                throw new ArgumentException("Titles list cannot be empty.", nameof(titles));
            }
        }
    }
}

/*
Generate a random wizard name (⭐)
Exercise description:

Implement the GenerateWizardName method, which uses two predefined lists: one of 
wizard names and one of wizard titles.

The method should randomly select one name from the first list and one title from 
the second list, then return the full wizard name in the format: "{Name} the {Title}" 
(for example: "Aldous the Shadow").

Use a provided Random instance as a parameter for testability.

ArgumentNullExceptions should be thrown on null parameters, and ArgumentExceptions on empty 
input lists (already implemented).

Example lists:
var names = new List<string> { "Magnus", "Seraphina", "Aldous", "Zephyra", "Thaddeus" };
var titles = new List<string> { "Blue", "Wise", "Shadow", "Bold", "Timeless" };

What you'll practice:
Random selection from collections
Using string interpolation

Example usage:
var names = new List<string> { "Magnus", "Seraphina", "Aldous", "Zephyra", "Thaddeus" };
var titles = new List<string> { "Blue", "Wise", "Shadow", "Bold", "Timeless" };
var random = new Random();
 
var wizardName = WizardNameGenerator.GenerateWizardName(names, titles, random);
// e.g. "Aldous the Shadow"
*/
