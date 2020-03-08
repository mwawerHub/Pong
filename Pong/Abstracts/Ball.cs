using System;
using Pong.Enums;

namespace Pong.Abstracts
{
    public class Ball : Shape
    {
        public Direction Direction { get; set; }

        public Ball()
        {
            Height = 1;
            Width = 1;
            XStartValue = (Board.BoardWidth + Board.BoardXMargin) / 2;
            YStartValue = (Board.BoardHeight + Board.BoardYMargin) / 2;
        }

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

        public void Move()
        {
            switch (Direction)
            {
                case Direction.NE:
                    MoveUp();
                    MoveRight();
                    break;
                case Direction.E:
                    MoveRight();
                    break;
                case Direction.SE:
                    MoveDown();
                    MoveRight();
                    break;
                case Direction.SW:
                    MoveDown();
                    MoveLeft();
                    break;
                case Direction.W:
                    MoveLeft();
                    break;
                case Direction.NW:
                    MoveUp();
                    MoveLeft();
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}
