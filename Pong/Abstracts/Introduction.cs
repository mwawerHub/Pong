using System;
using System.Collections.Generic;
using System.Text;

namespace Pong.Abstracts 
{
    public abstract class Introduction
    {
        public static void DrawInstructions(){
            Console.SetCursorPosition((Board.Width+Board.XMargin)/2, (Board.Height + Board.YMargin) / 2);
            Console.WriteLine("Player 1 - W S A D");
            Console.SetCursorPosition((Board.Width + Board.XMargin) / 2, (Board.Height + Board.YMargin) / 2 + 1);
            Console.WriteLine("Player 2 - Arrow keys");
        }


    }
}
