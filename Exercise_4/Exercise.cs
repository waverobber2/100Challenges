namespace Exercise_4;

public class Exercise
{
    public static List<string> GetQualifiedPlayers(Dictionary<string, int> playerScores)
    {
        //your code goes here
        const int QUALIFYING_SCORE = 50;
        const int DISQUALIFYING_SCORE = 100;

        var result = new List<string>();


        foreach (var player in playerScores)
        {
            if (player.Value >= DISQUALIFYING_SCORE)
            {
                break;
            }
            if (player.Value >= QUALIFYING_SCORE)
            {
                result.Add(player.Key);
            }
        }
        return result;
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
