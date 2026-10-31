using Xunit;

namespace Exercise_100.UnitTests;

public class WizardNameGeneratorTests
{
    [Fact]
    public void WizardNameGenerator_()
    {
        Assert.True(true);
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

