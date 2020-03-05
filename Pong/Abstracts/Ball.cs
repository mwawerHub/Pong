using System;

namespace Pong.Abstracts
{
    public class Ball : Shape
    {
        public override void Draw()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            for (var i = 0; i < Width; i++)
            {
                Console.SetCursorPosition(XStartValue + i, YStartValue);
                Console.WriteLine("o");
            }
            Console.ForegroundColor = ConsoleColor.White;
        }

        public Ball()
        {
            Height = 1;
            Width = 1;
            XStartValue = (Board.BoardWidth + Board.BoardXMargin) / 2;
            YStartValue = (Board.BoardHeight + Board.BoardYMargin) / 2;
        }
    }
}
