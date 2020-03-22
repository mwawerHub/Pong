using Pong.Abstracts;
using System;

namespace Pong.Objects {
    public class ScoreBoard
    {
        public int Player1Score { get; set; }
        public int Player2Score { get; set; }

        public void DrawScoreBoard()
        {
            Console.SetCursorPosition(Board.XMargin,Board.YMargin/2);
            Console.WriteLine("Player 1: " + Player1Score);
            Console.SetCursorPosition(Board.Width - Player2Score.ToString().Length - "Player 2: ".Length,Board.YMargin/2);
            Console.WriteLine("Player 2: " + Player2Score);
        }
    }
}
