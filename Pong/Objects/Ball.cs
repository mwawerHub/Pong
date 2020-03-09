using System;
using Pong.Abstracts;
using Pong.Enums;

namespace Pong.Objects
{
    public class Ball : Shape
    {
        public const int MovementSpeed = 50;

        private static readonly Random Rng = new Random();

        public Direction Direction { get; set; }
        public DateTime LastBallMovement { get; set; }
        public bool IsAtStartPosition { get; set; }      

        public Ball()
        {
            Height = 1;
            Width = 1;
            XStartValue = (Board.BoardWidth + Board.BoardXMargin) / 2;
            YStartValue = (Board.BoardHeight + Board.BoardYMargin) / 2;
            IsAtStartPosition = true;
            ChangeDirection();
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

        public bool CanMove()
        {
            return ((DateTime.Now - LastBallMovement).TotalMilliseconds > MovementSpeed);
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
            IsAtStartPosition = false;
            LastBallMovement = DateTime.Now;
        }

        public void ChangeDirection()
        {
            if (IsAtStartPosition)
                Direction = (Direction)Rng.Next(0, 5);
            else
                Direction = Direction switch
                {
                    Direction.NE => Direction.SE,
                    Direction.SE => Direction.NE,
                    Direction.SW => Direction.NW,
                    Direction.NW => Direction.SW,
                    Direction.E => Direction.W,
                    Direction.W => Direction.E,
                    _ => Direction
                };
        }
    }
}
