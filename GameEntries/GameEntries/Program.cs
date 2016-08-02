using System;

namespace GameEntries
{
    class Program
    {
        static void Main(string[] args)
        {
            GameEntry[] entries = new GameEntry[10]
            {
                new GameEntry("Peter",2311),
                new GameEntry("Adam",2334),
                new GameEntry("Hell",1235),
                new GameEntry("Lowr",2823),
                new GameEntry("Keir",2315),
                new GameEntry("Rush",2341),
                new GameEntry("John",2839),
                new GameEntry("juric",1293),
                new GameEntry("Dave",2983),
                new GameEntry("Noth",2315),
            };
            ScoreBoard leaderboard = new ScoreBoard(5);
            for (int i = 0; i < entries.Length; i++)
            {
                leaderboard.Add(entries[i]);
            }
            leaderboard.ShowBoard();
            Console.WriteLine();
            leaderboard.Remove(0);
            leaderboard.ShowBoard();
            leaderboard.Add(new GameEntry("Dávid", 3001));
            leaderboard.Add(new GameEntry("Dane", 1245));
            leaderboard.Add(new GameEntry("Kristine", 2825));
            leaderboard.Add(new GameEntry("Dawn", 1233));
            leaderboard.ShowBoard();
        }
    }
}
