using System;

namespace GameEntries
{
    public class ScoreBoard
    {
        private int numEntries = 0;
        private GameEntry[] board;

        public ScoreBoard(int capacity)
        {
            board = new GameEntry[capacity];
        }

        public void Add(GameEntry entry)
        {
            int newScore = entry.GetScore();
            if (numEntries < board.Length || newScore > board[numEntries - 1].GetScore())
            {
                if (numEntries < board.Length)
                {
                    numEntries++;
                }
                int j = numEntries - 1;
                while (j > 0 && board[j - 1].GetScore() < newScore)
                {
                    board[j] = board[j - 1];
                    j--;
                }
                board[j] = entry;
            }
        }

        public void Remove(int i)
        {
            if (i < 0 || i >= numEntries)
            {
                Console.WriteLine("Invalid index: {0}", i);                
            }

            GameEntry temp = board[i];

            for (int j = i; j < numEntries - 1; j++)
            {
                board[j] = board[j+1];
            }
            board[numEntries - 1] = null;
            numEntries--;            
        }

        public void ShowBoard()
        {
            for (int i = 0; i < board.Length; i++)
            {
                Console.WriteLine(board[i]);
            }
        }
    }
}
