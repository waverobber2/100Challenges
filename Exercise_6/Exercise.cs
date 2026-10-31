namespace Exercise_6;

public class Exercise
{
    public static void UpdateHighestScore(Player? player, int newScore)
    {
        if (player?.Statistics == null)
        {
            return;
        }

        player.Statistics.HighestScore ??= newScore;

        if (player.Statistics.HighestScore < newScore)
        {
            player.Statistics.HighestScore = newScore;
        }
    }
}

public class Player
{
    public Statistics? Statistics { get; set; }
}

public class Statistics
{
    public int? HighestScore { get; set; }
}

/*
Track the highest score for a player (⭐)
Exercise description:

Implement the UpdateHighestScore method that updates the highest score 
recorded in a player's statistics.

The player parameter may be null. Its Statistics property may also be null
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