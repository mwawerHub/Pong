using System;
using Pong.Abstracts;

namespace Pong.Players
{
    public class Player2 : ConsolePlayer
    {
        public Player2()
        {
            Width = 4;
            Height = 1;
            XStartValue = Board.BoardWidth;
            YStartValue = Board.BoardHeight / 2 - 2;
        }

        public override void Move(ConsoleKey key)
        {
            switch (key)
            {
                case ConsoleKey.UpArrow:
                    MoveUp();
                    break;
                case ConsoleKey.DownArrow:
                    MoveDown();
                    break;
            }
        }
    }
}
