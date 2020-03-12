using System;
using System.ComponentModel;
using System.Diagnostics;
using Pong.Abstracts;
using Pong.Enums;

namespace Pong.Objects
{
    public class Ball : Shape
    {
        public const byte MovementSpeed = 50;

        private static readonly Random Rng = new Random();

        public Direction Direction { get; set; }
        public Angle Angle { get; set; }
        public DateTime LastBallMovement { get; set; }
        public bool IsAtStartPosition { get; set; }

        public Ball()
        {
            Height = 1;
            Width = 1;
            XStartValue = (Board.Width + Board.XMargin) / 2;
            YStartValue = (Board.Height + Board.YMargin) / 2;
            IsAtStartPosition = true;
            ChangeDirection();
        }

        public override void Draw()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(LastXPosition, LastYPosition);
            Console.Write(" ");

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

        public void SetAngleAfterWallHit(byte x, byte y)
        {
            if (y == Board.YMargin || y == Board.Height)
                if (x <= Board.Width * 0.25) Angle = Angle.Angle30;
                else if (x > Board.Width * 0.25 && x < Board.Width * 0.5) Angle = Angle.Angle60;
                else if (x == (byte)(Board.Width * 0.5)) Angle = Angle.Angle90;
                else if (x < Board.Width * 0.75 && x > (Board.Width * 0.5)) Angle = Angle.Angle120;
                else if (x >= Board.Width * 0.75) Angle = Angle.Angle150;
        }

        public void SetAngleAfterPlayerHit(byte y)
        {
            Angle = (YStartValue - y) switch
            {
                0 => Angle.Angle30,
                1 => Angle.Angle60,
                2 => Angle.Angle90,
                3 => Angle.Angle120,
                4 => Angle.Angle150,
                _ => throw new InvalidEnumArgumentException("Given y value out of player range")
            };
        }

        public void ChangeDirection()
        {
            if (IsAtStartPosition)
            {
                Direction = Direction.E;
                Angle = Angle.Angle90;
                //Direction = (Direction)Rng.Next(0, 5);
                //Angle = (Angle)Rng.Next(0, 4);
            }
            else
            {
                if (Angle == Angle.Angle30)
                {
                    switch (Direction)
                    {
                        case Direction.NE:
                            Direction = Direction.NW;
                            break;
                        case Direction.E:
                            Direction = Direction.NW;
                            break;
                        case Direction.SE:
                            Direction = Direction.NW;
                            break;
                        case Direction.SW:
                            Direction = Direction.NE;
                            break;
                        case Direction.W:
                            Direction = Direction.NE;
                            break;
                        case Direction.NW:
                            Direction = Direction.NE;
                            break;
                        default:
                            throw new ArgumentOutOfRangeException();
                    }
                }
                else if (Angle == Angle.Angle60)
                {
                    switch (Direction)
                    {
                        case Direction.NE:
                            Direction = Direction.NW;
                            break;
                        case Direction.E:
                            Direction = Direction.NW;
                            break;
                        case Direction.SE:
                            Direction = Direction.NW;
                            break;
                        case Direction.SW:
                            Direction = Direction.NE;
                            break;
                        case Direction.W:
                            Direction = Direction.NE;
                            break;
                        case Direction.NW:
                            Direction = Direction.NE;
                            break;
                        default:
                            throw new ArgumentOutOfRangeException();
                    }
                }
                else if (Angle == Angle.Angle90)
                {
                    switch (Direction)
                    {
                        case Direction.NE:
                            Direction = Direction.W;
                            break;
                        case Direction.E:
                            Direction = Direction.W;
                            break;
                        case Direction.SE:
                            Direction = Direction.W;
                            break;
                        case Direction.SW:
                            Direction = Direction.E;
                            break;
                        case Direction.W:
                            Direction = Direction.E;
                            break;
                        case Direction.NW:
                            Direction = Direction.E;
                            break;
                        default:
                            throw new ArgumentOutOfRangeException();
                    }
                }
                else if (Angle == Angle.Angle120)
                {
                    switch (Direction)
                    {
                        case Direction.NE:
                            Direction = Direction.SW;
                            break;
                        case Direction.E:
                            Direction = Direction.SW;
                            break;
                        case Direction.SE:
                            Direction = Direction.SW;
                            break;
                        case Direction.SW:
                            Direction = Direction.SE;
                            break;
                        case Direction.W:
                            Direction = Direction.SE;
                            break;
                        case Direction.NW:
                            Direction = Direction.SE;
                            break;
                        default:
                            throw new ArgumentOutOfRangeException();
                    }
                }
                else if (Angle == Angle.Angle150)
                {
                    switch (Direction)
                    {
                        case Direction.NE:
                            Direction = Direction.SW;
                            break;
                        case Direction.E:
                            Direction = Direction.SW;
                            break;
                        case Direction.SE:
                            Direction = Direction.SW;
                            break;
                        case Direction.SW:
                            Direction = Direction.SE;
                            break;
                        case Direction.W:
                            Direction = Direction.SE;
                            break;
                        case Direction.NW:
                            Direction = Direction.SE;
                            break;
                        default:
                            throw new ArgumentOutOfRangeException();
                    }
                }

            }
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
    }
}
