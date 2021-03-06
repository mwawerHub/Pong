﻿using Pong.Abstracts;
using System;

namespace Pong.Behavior
{
    public abstract class Introduction
    {
        public static void DrawInstructions() {
            Console.SetCursorPosition((Board.Width - Board.XMargin) / 2, (Board.Height - Board.YMargin) / 2 - 3);
            Console.WriteLine("Instructions:");
            Console.SetCursorPosition((Board.Width - Board.XMargin) / 2, (Board.Height - Board.YMargin) / 2);
            Console.WriteLine("Player 1 - W S A D");
            Console.SetCursorPosition((Board.Width - Board.XMargin) / 2, (Board.Height - Board.YMargin) / 2 + 1);
            Console.WriteLine("Player 2 - Arrow keys");
            Console.SetCursorPosition((Board.Width - Board.XMargin) / 2, (Board.Height - Board.YMargin) / 2 + 4);
            Console.WriteLine("Have Fun!");
        }
    }
}