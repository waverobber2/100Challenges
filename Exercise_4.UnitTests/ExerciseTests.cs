using Xunit;

namespace Exercise_4.UnitTests;

public class ExerciseTests
{
    [Fact]
    public void GetQualifiedPlayers_ReturnsOnlyQualifiedPlayers_BeforeDisqualification()
    {
        // Arrange
        var players = new Dictionary<string, int>
        {
            { "Anna", 45 },
            { "Ben", 80 },
            { "Uki", 70 },
            { "Cara", 100 }, // cheating score - should stop here
            { "Derek", 90 },
            { "Ella", 70 }
        };

        // Act
        var result = Exercise.GetQualifiedPlayers(players);

        // Assert
        Assert.Equal(new List<string> { "Ben", "Uki" }, result);
    }

    [Fact]
    public void GetQualifiedPlayers_ReturnsEmptyList_WhenNoPlayersQualify()
    {
        // Arrange
        var players = new Dictionary<string, int>
        {
            { "Anna", 10 },
            { "Ben", 20 },
            { "Uki", 49 }
        };

        // Act
        var result = Exercise.GetQualifiedPlayers(players);

        // Assert
        Assert.Empty(result);
    }

    [Fact]
    public void GetQualifiedPlayers_ReturnsAllPlayers_WhenAllQualifyAndNoneDisqualified()
    {
        // Arrange
        var players = new Dictionary<string, int>
        {
            { "Anna", 50 },
            { "Ben", 75 },
            { "Uki", 99 }
        };

        // Act
        var result = Exercise.GetQualifiedPlayers(players);

        // Assert
        Assert.Equal(new List<string> { "Anna", "Ben", "Uki" }, result);
    }

    [Fact]
    public void GetQualifiedPlayers_StopsImmediately_WhenFirstPlayerIsDisqualified()
    {
        // Arrange
        var players = new Dictionary<string, int>
        {
            { "Cara", 100 },
            { "Ben", 80 },
            { "Uki", 70 }
        };

        // Act
        var result = Exercise.GetQualifiedPlayers(players);

        // Assert
        Assert.Empty(result);
    }

    [Fact]
    public void GetQualifiedPlayers_ReturnsEmptyList_WhenInputIsEmpty()
    {
        // Arrange
        var players = new Dictionary<string, int>();

        // Act
        var result = Exercise.GetQualifiedPlayers(players);

        // Assert
        Assert.Empty(result);
    }

    [Fact]
    public void GetQualifiedPlayers_ExcludesPlayer_WithScoreExactlyAtDisqualifyingThreshold()
    {
        // Arrange
        var players = new Dictionary<string, int>
        {
            { "Ben", 60 },
            { "Uki", 100 },
            { "Ella", 70 }
        };

        // Act
        var result = Exercise.GetQualifiedPlayers(players);

        // Assert
        Assert.Equal(new List<string> { "Ben" }, result);
    }

    [Fact]
    public void GetQualifiedPlayers_IncludesPlayer_WithScoreExactlyAtQualifyingThreshold()
    {
        // Arrange
        var players = new Dictionary<string, int>
        {
            { "Anna", 50 }
        };

        // Act
        var result = Exercise.GetQualifiedPlayers(players);

        // Assert
        Assert.Equal(new List<string> { "Anna" }, result);
    }
}

/*
Filter and select qualified players from a game leaderboard (⭐⭐)
Exercise description:

Implement the GetQualifiedPlayers method that takes a dictionary of player 
names and their scores.

Your goal is to build a list of players who qualify for the next round based on 
the following rules:

A player must have a score of at least 50 to qualify.
If a player has a score of 100 or more, the process should stop immediately—this 
    may indicate suspected cheating or a system rule violation. However, any players 
who qualified before this point should still be included in the result.
Return the list of names of players who qualified before any disqualifying score was 
    encountered.

What you'll practice:
Using foreach loops with continue and break
Filtering a dictionary based on multiple conditions
Working with collections and building a result list
Avoiding magic numbers by using named constants

Optionally, using LINQ with TakeWhile, Where, and Select methods

Example usage:

var players = new Dictionary<string, int>
{
    { "Anna", 45 },
    { "Ben", 80 },
    { "Uki", 70 },
    { "Cara", 100 }, //cheating score - we should stop right there
    { "Derek", 90 },
    { "Ella", 70 }
};
 
var result = Exercise.GetQualifiedPlayers(players);
// result: ["Ben", "Uki"]
*/

