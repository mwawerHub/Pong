using System;

namespace Pong
{
    public class Player1 : ConsolePlayer
    {
        public Player1()
        {
            Width = 4;
            Height = 1;
            XStartValue = Board.BoardXMargin;
            YStartValue = Board.BoardHeight / 2 - 2;
        }

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
    }
}