using System;

namespace Pong.Abstracts
{
    public abstract class Wall : Shape
    { 
        public override void Draw()
        {
            Console.BackgroundColor = ConsoleColor.White;
            for (var i = 0; i < Width; i++)
            {
                Console.SetCursorPosition(XStartValue + i, YStartValue);
                Console.WriteLine("o");
            }
            Console.BackgroundColor = ConsoleColor.Black;
        }

        protected Wall()
        {
            XStartValue = Board.BoardXMargin;
            Width = Board.BoardWidth - XStartValue;
            Height = 1;
        }
    }
}
