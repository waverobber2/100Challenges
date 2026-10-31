using Xunit;

namespace Exercise_6.UnitTests;

public class ExerciseTests
{
    [Fact]
    public void UpdateHighestScore_WhenPlayerIsNull_DoesNothingAndDoesNotThrow()
    {
        var exception = Record.Exception(() => Exercise.UpdateHighestScore(null, 100));

        Assert.Null(exception);
    }

    [Fact]
    public void UpdateHighestScore_WhenStatisticsIsNull_DoesNothingAndDoesNotThrow()
    {
        var player = new Player { Statistics = null };

        var exception = Record.Exception(() => Exercise.UpdateHighestScore(player, 100));

        Assert.Null(exception);
        Assert.Null(player.Statistics);
    }

    [Fact]
    public void UpdateHighestScore_WhenHighestScoreIsNull_SetsHighestScoreToNewScore()
    {
        var player = new Player
        {
            Statistics = new Statistics { HighestScore = null }
        };

        Exercise.UpdateHighestScore(player, 100);

        Assert.Equal(100, player.Statistics!.HighestScore);
    }

    [Fact]
    public void UpdateHighestScore_WhenNewScoreIsLower_DoesNotChangeHighestScore()
    {
        var player = new Player
        {
            Statistics = new Statistics { HighestScore = 100 }
        };

        Exercise.UpdateHighestScore(player, 90);

        Assert.Equal(100, player.Statistics!.HighestScore);
    }

    [Fact]
    public void UpdateHighestScore_WhenNewScoreIsHigher_UpdatesHighestScore()
    {
        var player = new Player
        {
            Statistics = new Statistics { HighestScore = 100 }
        };

        Exercise.UpdateHighestScore(player, 150);

        Assert.Equal(150, player.Statistics!.HighestScore);
    }

    [Fact]
    public void UpdateHighestScore_WhenNewScoreIsEqual_DoesNotChangeHighestScore()
    {
        var player = new Player
        {
            Statistics = new Statistics { HighestScore = 100 }
        };

        Exercise.UpdateHighestScore(player, 100);

        Assert.Equal(100, player.Statistics!.HighestScore);
    }
}

/*
Track the highest score for a player (⭐)
Exercise description:

Implement the UpdateHighestScore method that updates the highest score 
recorded in a player's statistics.

The player parameter may be null. Its Statistics property may also be null , 
and so can be its HighestScore property.

If the player or their statistics are null, the method should do nothing 
(it should not update any data or throw an exception).

If HighestScore is null, set it to the provided newScore.

If the existing HighestScore is lower than newScore, update it—so that it always 
stores the highest value.

What you'll practice:
Working with nullable reference types and nullable value types
Using the null-conditional operator (?.)
Using the null-coalescing assignment operator (??=)
Writing clean, defensive logic with object hierarchies

Example usage:
var player = new Player
{
    Statistics = new Statistics { HighestScore = null }
};
 
Exercise.UpdateHighestScore(player, 100);
// player.Statistics.HighestScore is now 100
 
Exercise.UpdateHighestScore(player, 90);
    score is lower than current — no change
 
Exercise.UpdateHighestScore(player, 150);
    score is higher — should update
    player.Statistics.HighestScore is now 150
*/
