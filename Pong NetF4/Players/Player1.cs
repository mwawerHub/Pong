using System;
using Pong.Abstracts;

namespace Pong.Players
{
    public class Player1 : ConsolePlayer
    {
        public override void Move(ConsoleKey key){
            switch (key){
                case ConsoleKey.W:
                    MoveUp();
                    break;
                case ConsoleKey.S:
                    MoveDown();
                    break;
            }
        }

        public Player1(){
            Width = 5;
            Height = 1;
            XStartValue = LastXPosition = Board.XMargin ;
            YStartValue = LastYPosition = (Board.Height - 1) / 2 + 3;
        }
    }
}