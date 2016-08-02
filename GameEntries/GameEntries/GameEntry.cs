using System;

namespace GameEntries
{
    public class GameEntry
    {
        private string player;
        private int score;

        public GameEntry(string player, int score)
        {
            this.player = player;
            this.score = score;
        }

        public string GetName() { return player; }
        public int GetScore() { return score; }

        public override string ToString()
        {
            return player + ", " + score;
        }
    }
}
