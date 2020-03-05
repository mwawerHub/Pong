using System;

namespace Pong.Abstracts
{
    public abstract class Wall : Shape
    { 
        public override void Draw()
        {
            for (var i = 0; i < Width; i++)
            {
                Console.SetCursorPosition(XStartValue + i, YStartValue);
                Console.WriteLine("o");
            }
        }

        protected Wall()
        {
            XStartValue = Board.BoardXMargin;
            Width = Board.BoardWidth - XStartValue;
            Height = 1;
        }
    }
}
