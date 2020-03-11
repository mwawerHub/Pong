using System;
using Pong.Abstracts;

namespace Pong.Players
{
    public class Player2 : ConsolePlayer
    {
        public override void Move(ConsoleKey key){
            switch (key){
                case ConsoleKey.UpArrow:
                    MoveUp();
                    break;
                case ConsoleKey.DownArrow:
                    MoveDown();
                    break;
            }
        }

        public Player2(){
            Width = 5;
            Height = 1;
            XStartValue = LastXPosition = Board.BoardWidth;
            YStartValue = LastYPosition = (Board.BoardHeight - 1) / 2 + 3;
        }
    }
}
