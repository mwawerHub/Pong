using System;
using Pong.Abstracts;

namespace Pong.Players
{
    public class Player1 : ConsolePlayer
    {
        public override void Move(ConsoleKey key)
        {
            switch (key)
            {
                case ConsoleKey.W:
                    MoveUp();
                    break;
                case ConsoleKey.S:
                    MoveDown();
                    break;
            }
        }

        public Player1()
        {
            Width = 4;
            Height = 1;
            XStartValue = Board.BoardXMargin;
            YStartValue = Board.BoardHeight / 2 - 2;
        }
    }
}