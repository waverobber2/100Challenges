using Xunit;

namespace Exercise_11.UnitTests;

public class ExerciseTests
{
    [Fact]
    public void Test1()
    {
        Assert.True(true);
    }
}

/*
Read file content safely (⭐)
Exercise description:

Implement the TryReadFile method that takes a file name and attempts 
to read it using IFileSystem.ReadFile.

If the file exists, return its contents.

If the file does not exist (throws FileNotFoundException), log a warning 
(using ILogger) with the exception message and rethrow the exception. 
The warning can be a string in any format you like, but it must contain 
the exception's Message property.

Whether the file is found or not, always log "Attempted to read file: 
[filename]" using the ILogger.

What you'll practice:
Using try-catch-finally for robust control flow
Catching and rethrowing exceptions to preserve error context
Returning values from methods that may fail while ensuring side effects 
    (e.g. logging) are always performed

Example usage:
var fileSystem = new InMemoryFileSystem();
var logger = new ConsoleLogger();
 
var exercise = new Exercise(fileSystem, logger);
 
try
{
    var content = exercise.TryReadFile("readme.txt");
    Console.WriteLine(content);
}
catch (FileNotFoundException)
{
    Console.WriteLine("The file was missing.");
}
*/

