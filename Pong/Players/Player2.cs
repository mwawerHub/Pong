﻿using Pong.Abstracts;
using System;

namespace Pong.Players
{
    public class Player2 : ConsolePlayer
    {
        public override void Move(ConsoleKey key) {
            switch (key) {
                case ConsoleKey.UpArrow:
                    MoveUp();
                    break;

                case ConsoleKey.DownArrow:
                    MoveDown();
                    break;
            }
        }

        public Player2() {
            Width = 5;
            Height = 1;
            XStartValue = LastXPosition = Board.Width;
            YStartValue = LastYPosition = (Board.Height - 1) / 2 + 3;
        }
    }
}