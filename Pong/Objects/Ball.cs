using System;
using System.ComponentModel;
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

        public Ball(){
            Height = 1;
            Width = 1;
            XStartValue = (Board.BoardWidth + Board.BoardXMargin) / 2;
            YStartValue = (Board.BoardHeight + Board.BoardYMargin) / 2;
            IsAtStartPosition = true;
            ChangeDirection();
        }

        public override void Draw(){
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(LastXPosition, LastYPosition);
            Console.Write(" ");

            for (var i = 0; i < Width; i++){
                Console.SetCursorPosition(XStartValue + i, YStartValue);
                Console.WriteLine("o");
            }
            Console.ForegroundColor = ConsoleColor.White;
        }

        public bool CanMove(){
            return ((DateTime.Now - LastBallMovement).TotalMilliseconds > MovementSpeed);
        }

        public void SetAngle(int y){
            if (YStartValue - y == 0 || YStartValue - y == 4) Angle = Angle.Angle30;
            else if (YStartValue - y == 1 || YStartValue - y == 3) Angle = Angle.Angle45;
            else if (YStartValue - y == 2) Angle = Angle.Angle90;
            else throw new InvalidEnumArgumentException("Given y value out of player range");
        }

        public void Move(){
            switch (Direction){
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

        public void ChangeDirection(){
            if (IsAtStartPosition) Direction = (Direction)Rng.Next(0, 5);
            else Direction = Direction switch{
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
